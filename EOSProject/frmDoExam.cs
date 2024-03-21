using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EOSProject {
    public partial class frmDoExam : Form {

        public User UserLogged { get; set; }

        public Test test { get; set; }

        public List<Question> questions = null;

        public int numberOfChoosen = 0;

        public int currentQuestion = 1;

        public int currentButton = 1;

        public string submitTime = string.Empty;

        private System.Windows.Forms.Timer timer;

        private int countdownMinutes = 2;
        private int countdownSeconds = 0;



        public List<TestDetail> listTestDetail = new List<TestDetail>();

        public frmDoExam() {
            InitializeComponent();

        }

        private void frmDoExam_Load(object sender, EventArgs e) {
            InitializeTimer();

            //SetEventCheckedRadio();
            LoadText();
            CreateQuestion();
            CreateButtonsQuestion(questions);
            lbNumberQuestion.Text = "Multiple choices 0/" + (int)test.NumberOfQuestion;
            Button currentBtn = GetButtonByName("" + currentQuestion);
            currentBtn.BackColor = Color.CornflowerBlue;


            LoadQuestion(questions[0]);
        }

        private void LoadText() {
            lbTimeTest.Text = test.TestTime + "minutes";
            lbSubject.Text = test.SubjectId;
            lbNumQuestion.Text = test.NumberOfQuestion.ToString();
        }

        private int GetNumberOfChoosen() {
            int count = 0;
            foreach (var item in listTestDetail)
            {
                if(item.OptionChoosen > 0) {
                    count++;
                }
            }
            return count;
        }

        private void updateTitle() {
            int numberOfChoosen = GetNumberOfChoosen();
            lbNumberQuestion.Text = "Multiple choices " + numberOfChoosen + "/" + (int)test.NumberOfQuestion;
        }

        private void CreateQuestion() {
            int testId = test.TestId;

            //If nobody has done this test
            if (!TestDAO.isTestDoneByAnother(testId)) {
                questions = QuestionDAO.
                   GetRandomNumberOfQuestion((int)test.NumberOfQuestion, (int)test.ExamId, test.SubjectId);

                foreach (var item in questions) {
                    TestDetail testDetail = new TestDetail {
                        QuestionId = item.QuestionId,
                        TestId = testId,
                        UserId = UserLogged.UserId,
                        OptionChoosen = 0
                    };

                    listTestDetail.Add(testDetail);
                    TestDetailDAO.AddNewTestDetail(testDetail);
                }
            }

            //This test has been done by another
            else {
                questions = TestDetailDAO.GetListQuestionInTestDetail(testId);
                foreach (var item in questions) {
                    TestDetail testDetail = new TestDetail {
                        QuestionId = item.QuestionId,
                        TestId = testId,
                        UserId = UserLogged.UserId,
                        OptionChoosen = 0
                    };

                    listTestDetail.Add(testDetail);
                    TestDetailDAO.AddNewTestDetail(testDetail);
                }
            }

            if(questions.Count() != 0) {
                currentQuestion = questions[0].QuestionId;
            }
            else {
                MessageBox.Show("This test have no question");
            }

        }

        private void InitializeTimer() {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            if (countdownSeconds == 0) {
                if (countdownMinutes == 0) {
                    // Countdown finished
                    timer.Stop();

                    foreach (var item in listTestDetail) {
                        TestDetailDAO.UpdateTestDetail(item);
                    }
                    submitTime = lbCountDown.Text;
                    frmFinish frmFinish = new frmFinish {
                        test = test,
                        submitTime = submitTime
                    };
                    this.Close();
                    frmFinish.Show();

                    return;
                }
                countdownMinutes--;
                countdownSeconds = 59;
            }
            else {
                countdownSeconds--;
            }

            UpdateTimerDisplay();
        }

        private void UpdateTimerDisplay() {
            lbCountDown.Text = $"{countdownMinutes:00}:{countdownSeconds:00}";
        }

        //private void SetEventCheckedRadio() {
        //    foreach (Control control in grOption.Controls) {
        //        if (control is RadioButton radioButto) {
        //            radioButto.CheckedChanged += RadioButto_CheckedChanged;
        //        }
        //    }
        //}

        //private void RadioButto_CheckedChanged(object? sender, EventArgs e) {
        //    TestDetail testDetail = TestDetailDAO.GetTestDetail(test.TestId, UserLogged.UserId, currentQuestion);
        //    testDetail.OptionChoosen = getOptionChecked();
        //    TestDetailDAO.UpdateTestDetail(testDetail);
        //}

        public int GetChoosenOption(int questionId) {
            int n = 0;

            foreach (var item in listTestDetail) {
                TestDetail testDetail = GetTestDetail(listTestDetail, questionId);
                n = (int)testDetail.OptionChoosen;
            }
            return n;
        }

        private void LoadQuestion(Question question) {
            int choosenOption = (int)GetTestDetail(listTestDetail, question.QuestionId).OptionChoosen;
            List<Option> options = OptionDAO.getListAnswers(question.QuestionId);
            int length = options.Count() - 1;
            rtbQuestion.Text = question.QuestionContent + "\n\n";


            //Named for each radio
            foreach (Control control in grOption.Controls) {
                if (control is RadioButton radioButto) {
                    if (options[length].OptionId == choosenOption) {
                        radioButto.Checked = true;
                    }
                    else {
                        radioButto.Checked = false;
                    }
                    radioButto.Name = "rd_" + options[length].OptionId;
                    length--;
                }
            }


            //Fill content to rich text box
            for (int i = 0; i < options.Count; i++) {
                rtbQuestion.Text += options[i].OptionContent + "\n";
            }
        }

        private void CreateButtonsQuestion(List<Question> questions) {
            int x = 12;
            int y = 760;
            int buttonWidth = 51;
            int buttonHeight = 46;
            int buttonSpacing = 5;

            for (int i = 0; i < questions.Count(); i++) {
                Button button = new Button();
                button.Size = new Size(buttonWidth, buttonHeight);
                button.Location = new Point(x, y);
                button.Text = "" + (i + 1);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Name = questions[i].QuestionId + "";
                button.Click += Button_Click;
                button.Font = new Font(button.Font, FontStyle.Bold);
                this.Controls.Add(button);


                x += buttonWidth + buttonSpacing;

                if (x > 1700) {
                    x = 12;
                    y += buttonHeight + buttonSpacing;
                }
            }
        }

        private TestDetail GetTestDetail(List<TestDetail> listTestDetail, int questionId) {
            foreach (var item in listTestDetail) {
                if (item.QuestionId == questionId) {
                    return item;
                }
            }
            return null;
        }

        private void Button_Click(object? sender, EventArgs e) {

            //Update old question detail
            //TestDetail testDetail = TestDetailDAO.GetTestDetail(test.TestId, UserLogged.UserId, currentQuestion);
            //testDetail.OptionChoosen = getOptionChecked();
            //TestDetailDAO.UpdateTestDetail(testDetail);

            TestDetail testDetail = GetTestDetail(listTestDetail, currentQuestion);
            testDetail.OptionChoosen = getOptionChecked();


            Button currentBtn = GetButtonByName("" + currentQuestion);
            if (isCurrentChecked()) {
                currentBtn.BackColor = Color.Chartreuse;
                updateTitle();

            }
            else {
                currentBtn.BackColor = Color.White;
            }


            Button nextBtn = (Button)sender;
            nextBtn.BackColor = Color.CornflowerBlue;
            int questionId = Convert.ToInt32(nextBtn.Name);
            currentQuestion = questionId;
            currentButton = Convert.ToInt32(nextBtn.Text);
            Question question = QuestionDAO.getQuestionById(questionId);
            LoadQuestion(question);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            btnFinish.Enabled = !btnFinish.Enabled;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            string nextBtnText = "1";
            if (currentButton + 1 <= test.NumberOfQuestion) {
                nextBtnText = (currentButton + 1).ToString();
            }

            Button nextBtn = GetButtonByText(nextBtnText);

            nextBtn.PerformClick();
        }

        private int getOptionChecked() {
            foreach (Control control in grOption.Controls) {
                if (control is RadioButton radioButton && radioButton.Checked) {
                    return Convert.ToInt32(radioButton.Name.Split("_")[1]);
                }
            }
            return 0;
        }

        private bool isCurrentChecked() {
            foreach (Control control in grOption.Controls) {
                if (control is RadioButton radioButton && radioButton.Checked) {
                    return true;
                }
            }
            return false;
        }

        private Button GetButtonByName(string buttonName) {
            foreach (Control control in Controls) {
                if (control is Button button && button.Name == buttonName) {
                    return button;
                }
            }
            return null;
        }

        private Button GetButtonByText(string buttonText) {
            foreach (Control control in Controls) {
                if (control is Button button && button.Text == buttonText) {
                    return button;
                }
            }
            return null;
        }

        private void btnFinish_Click(object sender, EventArgs e) {
            foreach (var item in listTestDetail)
            {
                TestDetailDAO.UpdateTestDetail(item);
            }
            submitTime = lbCountDown.Text;
            frmFinish frmFinish = new frmFinish {
                test = test,
                submitTime = submitTime
            };
            this.Close();
            frmFinish.Show();
        }
    }
}
