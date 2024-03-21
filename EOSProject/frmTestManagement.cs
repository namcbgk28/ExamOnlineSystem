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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EOSProject {
    public partial class frmTestManagement : Form {
        public User UserLogged { get; set; }
        public frmTestManagement() {
            InitializeComponent();
        }

        int examId = 0;
        string subjectId = "";
        static DateTime toSearch = DateTime.Today;
        static DateTime fromSearch = toSearch.AddDays(-7);

        private void frmTestManagement_Load(object sender, EventArgs e) {
            DateTime toDate = DateTime.Today;
            DateTime fromDate = toDate.AddDays(-7);
            dtpFromDate.Value = fromDate;
            dtpToDate.Value = toDate;

            //toSearch = toDate;
            //fromSearch = fromDate;


            LoadComboBox();
            LoadTest();


        }

        private void LoadComboBox() {
            cbSubject.DataSource = SubjectDAO.getAllSubjects();
            cbSubject.DisplayMember = "SubjectId";
            cbSubject.ValueMember = "SubjectId";


            cbSubjects.DataSource = SubjectDAO.getAllSubjects();
            cbSubjects.DisplayMember = "SubjectId";
            cbSubjects.ValueMember = "SubjectId";

            cbExam.DataSource = ExamDAO.getAllExams();
            cbExam.DisplayMember = "ExamName";
            cbExam.ValueMember = "ExamId";

            cbExams.DataSource = ExamDAO.getAllExams();
            cbExams.DisplayMember = "ExamName";
            cbExams.ValueMember = "ExamId";

            examId = (cbExam.SelectedItem as Exam).ExamId;
            subjectId = (cbSubject.SelectedItem as Subject).SubjectId;
        }

        private void LoadTest() {
            var tests = TestDAO.GetListTest(examId, subjectId, fromSearch, toSearch);

            dgvTestList.DataSource = tests;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmTestManagement_FormClosed(object sender, FormClosedEventArgs e) {
            frmMain frmMain = new frmMain {
                UserLogged = UserLogged
            };
            frmMain.Show();
        }

        

        private void Clear() {
            tbTestCode.Text = string.Empty;
            cbSubject.SelectedIndex = 0;
            cbExam.SelectedIndex = 0;
            numPaperNo.Value = numPaperNo.Minimum;
            numTimeTest.Value = numTimeTest.Minimum;
            rdOn.Checked = true;
            numNumOfQuestion.Value = numNumOfQuestion.Minimum;
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e) {
            subjectId = (cbSubjects.SelectedItem as Subject).SubjectId;
            LoadTest();
        }

        private void cbExams_SelectedIndexChanged(object sender, EventArgs e) {
            examId = (cbExams.SelectedItem as Exam).ExamId;
            LoadTest();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e) {
            fromSearch = dtpFromDate.Value;
            if(fromSearch > dtpToDate.Value) {
                MessageBox.Show("The date cannot go beyond the specified end date.");
            }
            else {
                LoadTest();
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e) {
            toSearch = dtpToDate.Value;
            LoadTest();
        }

        private void dgvTestList_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                tbTestCode.Text = dgvTestList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cbSubject.SelectedValue = dgvTestList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                cbExam.SelectedItem = dgvTestList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                numPaperNo.Value = Convert.ToDecimal(dgvTestList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                rdOn.Checked = dgvTestList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString() == "ON" ? true : false;
                rdOff.Checked = dgvTestList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString() == "OFF" ? true : false;
                numTimeTest.Value = Convert.ToDecimal(dgvTestList.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                numNumOfQuestion.Value = Convert.ToDecimal(dgvTestList.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Clear();
        }

        private void Update_Click(object sender, EventArgs e) {
            if(tbTestCode.Text == "") {
                MessageBox.Show("Invalid Update");
                return;
            }

            try {
                int testId = Convert.ToInt32(dgvTestList.SelectedRows[0].Cells["TestID"].FormattedValue.ToString());


                Test test = new Test {
                    TestId = testId,
                    TestCode = tbTestCode.Text,
                    SubjectId = (cbSubject.SelectedItem as Subject).SubjectId,
                    ExamId = (cbExam.SelectedItem as Exam).ExamId,
                    PaperNo = Convert.ToInt32(numPaperNo.Value),
                    TestTime = Convert.ToInt32(numTimeTest.Value),
                    Status = rdOn.Checked,
                    CreatedDate = DateTime.Today,
                    NumberOfQuestion = Convert.ToInt32(numNumOfQuestion.Value)
                };

                TestDAO.UpdateTest(test);
                MessageBox.Show("Update Test Successfully!");
                Clear();
                LoadTest();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (tbTestCode.Text != "") {
                MessageBox.Show("This test is exist!");
                return;
            }

            try {
                Random random = new Random();

                int randomNumber = random.Next(100000, 1000000);
                string subjectIdAdd = (cbSubject.SelectedItem as Subject).SubjectId;
                string examName = (cbExam.SelectedItem as Exam).ExamName;
                string[] word = examName.Split(" ");
                int examIdAdd = (cbExam.SelectedItem as Exam).ExamId;

                bool status = false;
                if (rdOn.Checked) {
                    status = true;
                }


                string testCode = subjectIdAdd + "_" + examName.Substring(Math.Max(0, examName.Length - 4)) + "_"
                    + word[0].Substring(0, 1) + word[1].Substring(0, 1) + "_" + randomNumber;

                DateTime CreatedDate = DateTime.Now;
                int testTime = Convert.ToInt32(numTimeTest.Value);
                int paperNo = Convert.ToInt32(numPaperNo.Value);
                int numberOfQuestion = Convert.ToInt32(numNumOfQuestion.Value);

                Test newTest = new Test {
                    TestId = TestDAO.GetMaxId() + 1,
                    TestCode = testCode,
                    SubjectId = subjectIdAdd,
                    ExamId = examIdAdd,
                    PaperNo = paperNo,
                    Status = status,
                    TestTime = testTime,
                    CreatedDate = CreatedDate,
                    NumberOfQuestion = numberOfQuestion

                };

                TestDAO.AddNewTest(newTest);
                MessageBox.Show("Add New Test Successfully!");
                Clear();
                LoadTest();
            }
            catch (Exception) {
                MessageBox.Show("Invalid input! Please check again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }
    }
}
