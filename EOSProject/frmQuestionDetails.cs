using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;

namespace EOSProject {
    public partial class frmQuestionDetails : Form {

        public bool InsertOrUpdate { get; set; }

        public Question question { get; set; }
        public frmQuestionDetails() {
            InitializeComponent();
        }

        private List<bool> GetAnswers() {
            List<bool> radioList = new List<bool>();

            foreach (Control control in groupBox2.Controls) {
                if (control is RadioButton radioButton && radioButton.Checked) {
                    radioList.Add(true);
                }
                else if (control is RadioButton radioBtn && !radioBtn.Checked) {
                    radioList.Add(false);
                }
            }

            return radioList;
        }

        private List<string> GetContent() {
            List<string> stringList = new List<string>();

            foreach (Control control in groupBox2.Controls) {
                if (control is RichTextBox content && content.Name.StartsWith("contentOption")) {
                    stringList.Add(content.Text);
                }
            }

            return stringList;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                if (InsertOrUpdate == false) {
                    var question = new Question {
                        QuestionId = Convert.ToInt32(tbQuestionID.Text),
                        QuestionContent = tbQuestionContent.Text,
                        SubjectId = (cbSubject.SelectedItem as Subject).SubjectId,
                        ExamId = (cbExam.SelectedItem as Exam).ExamId
                    };

                    QuestionDAO.AddNewQuestion(question);

                    var listContents = GetContent();
                    var listAnswers = GetAnswers();
                    for (int i = listAnswers.Count() - 1; i >= 0; i--) {
                        var option = new Option {
                            QuestionId = Convert.ToInt32(tbQuestionID.Text),
                            OptionContent = listContents[i],
                            RightAnswer = listAnswers[i],
                            OptionId = OptionDAO.getMaxId() + 1
                        };
                        OptionDAO.AddNewOption(option);
                    }



                    MessageBox.Show("Add new Success");
                }

                else {

                    var question = new Question {
                        QuestionId = Convert.ToInt32(tbQuestionID.Text),
                        QuestionContent = tbQuestionContent.Text,
                        SubjectId = (cbSubject.SelectedItem as Subject).SubjectId,
                        ExamId = (cbExam.SelectedItem as Exam).ExamId
                    };

                    QuestionDAO.UpdateQuestion(question);
                    List<Option> options = OptionDAO.getListAnswers(question.QuestionId);
                    var listContents = GetContent();
                    var listAnswers = GetAnswers();
                    for (int i = listAnswers.Count() - 1; i >= 0; i--) {
                        int index = listAnswers.Count() - 1 - i;
                        var option = new Option {
                            QuestionId = Convert.ToInt32(tbQuestionID.Text),
                            OptionContent = listContents[i],
                            RightAnswer = listAnswers[i],
                            OptionId = options[index].OptionId
                        };
                        OptionDAO.Update(option);
                    }



                    MessageBox.Show("Update Success");
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new question" : "Update a question");
            }
        }

        private void frmQuestionDetails_Load(object sender, EventArgs e) {
            //lbOrder.Text = "ORDER #" + order.OrderId;
            if (InsertOrUpdate) {
                cbSubject.DataSource = SubjectDAO.getAllSubjects();
                cbSubject.DisplayMember = "SubjectId";
                cbSubject.ValueMember = "SubjectId";


                cbExam.DataSource = ExamDAO.getAllExams();
                cbExam.DisplayMember = "ExamName";
                cbExam.ValueMember = "ExamId";

                tbQuestionID.Text = question.QuestionId.ToString();
                tbQuestionID.ReadOnly = true;

                tbQuestionContent.Text = question.QuestionContent;
                cbSubject.SelectedValue = question.SubjectId;
                cbExam.SelectedValue = question.ExamId;

                List<Option> options = OptionDAO.getListAnswers(question.QuestionId);
                for (int i = 0; i < options.Count(); i++) {
                    RichTextBox richTextBox = groupBox2.Controls["contentOption" + (i + 1)] as RichTextBox;
                    RadioButton radioButton = groupBox2.Controls["rdOption" + (i + 1)] as RadioButton;

                    richTextBox.Text = options[i].OptionContent;
                    radioButton.Checked = options[i].RightAnswer == true ? true : false;
                }
            }
            else {
                cbSubject.DataSource = SubjectDAO.getAllSubjects();
                cbSubject.DisplayMember = "SubjectId";
                cbSubject.ValueMember = "SubjectId";


                cbExam.DataSource = ExamDAO.getAllExams();
                cbExam.DisplayMember = "ExamName";
                cbExam.ValueMember = "ExamId";

                tbQuestionID.Text = (QuestionDAO.getMaxId() + 1).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
