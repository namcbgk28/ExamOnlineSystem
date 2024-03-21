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

namespace EOSProject {
    public partial class frmQuestionManagement : Form {

        public User UserLogged { get; set; }
        public frmQuestionManagement() {
            InitializeComponent();
        }

        int examId = 0;
        string subjectId = "";
        string key = "";

        private void QuestionManagement_Load(object sender, EventArgs e) {
            LoadComboBox();
            LoadQuestion();
        }

        private void LoadComboBox() {
            cbSubject.DataSource = SubjectDAO.getAllSubjects();
            cbSubject.DisplayMember = "SubjectId";
            cbSubject.ValueMember = "SubjectId";


            cbExam.DataSource = ExamDAO.getAllExams();
            cbExam.DisplayMember = "ExamName";
            cbExam.ValueMember = "ExamId";

            examId = (cbExam.SelectedItem as Exam).ExamId;
            subjectId = (cbSubject.SelectedItem as Subject).SubjectId;
        }

        private void LoadAnswer(int questionId) {
            var options = OptionDAO.getListAnswers(questionId);
            dgvAnswer.DataSource = null;
            dgvAnswer.DataSource = options;
        }

        private void LoadQuestion() {
            var questions = QuestionDAO.getListQuestions(examId, subjectId, key);

            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = questions;

            if (dgvQuestion.SelectedRows.Count > 0) {
                DataGridViewRow selectedRowUpdate = dgvQuestion.SelectedRows[0];
                int questionIdUpdate = Convert.ToInt32(selectedRowUpdate.Cells["QuestionId"].Value);
                LoadAnswer(questionIdUpdate);
            }
            else {
                dgvAnswer.DataSource = null;
            }
        }



        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e) {
            subjectId = (cbSubject.SelectedItem as Subject).SubjectId;
            LoadQuestion();
            if (dgvQuestion.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dgvQuestion.SelectedRows[0];
                int questionId = Convert.ToInt32(selectedRow.Cells["QuestionId"].Value);
                LoadAnswer(questionId);
            }
            else {
                dgvAnswer.DataSource = null;
            }
        }

        private void cbExam_SelectedIndexChanged(object sender, EventArgs e) {
            examId = (cbExam.SelectedItem as Exam).ExamId;
            LoadQuestion();
            if (dgvQuestion.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dgvQuestion.SelectedRows[0];
                int questionId = Convert.ToInt32(selectedRow.Cells["QuestionId"].Value);
                LoadAnswer(questionId);
            }
            else {
                dgvAnswer.DataSource = null;
            }
        }



        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int questionId = Convert.ToInt32(dgvQuestion.Rows[e.RowIndex].Cells["QuestionId"].Value);
                LoadAnswer(questionId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (dgvQuestion.SelectedRows.Count >= 0) {
                //DataGridViewRow selectedRow = dgvQuestion.SelectedRows[0];
                //int questionId = Convert.ToInt32(selectedRow.Cells["QuestionId"].Value);
                //Question question = QuestionDAO.getQuestionById(questionId);

                frmQuestionDetails frmQuestionDetails = new frmQuestionDetails {
                    Text = "Add Question",
                    InsertOrUpdate = false,
                };

                if (frmQuestionDetails.ShowDialog() == DialogResult.OK) {
                    LoadQuestion();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (dgvQuestion.SelectedRows.Count >= 0) {
                DataGridViewRow selectedRow = dgvQuestion.SelectedRows[0];
                int questionId = Convert.ToInt32(selectedRow.Cells["QuestionId"].Value);
                Question question = QuestionDAO.getQuestionById(questionId);
                frmQuestionDetails frmQuestionDetails = new frmQuestionDetails {
                    Text = "Update Question",
                    InsertOrUpdate = true,
                    question = question
                };

                if (frmQuestionDetails.ShowDialog() == DialogResult.OK) {
                    LoadQuestion();

                    if (dgvQuestion.SelectedRows.Count > 0) {
                        DataGridViewRow selectedRowUpdate = dgvQuestion.SelectedRows[0];
                        int questionIdUpdate = Convert.ToInt32(selectedRowUpdate.Cells["QuestionId"].Value);
                        LoadAnswer(questionIdUpdate);
                    }
                    else {
                        dgvAnswer.DataSource = null;
                    }
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {
            key = textBox1.Text;
            LoadQuestion();
        }

        private void frmQuestionManagement_FormClosed(object sender, FormClosedEventArgs e) {
            frmMain frmMain = new frmMain {
                UserLogged = UserLogged
            };
            frmMain.Show();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnAddto_Click(object sender, EventArgs e) {
            if (dgvQuestion.SelectedRows.Count < 0) {
                MessageBox.Show("Select the question you want to add");
            }
            else {
                List<Question> questions = new List<Question>();
                string subjectId = string.Empty;
                foreach (DataGridViewRow row in dgvQuestion.SelectedRows) {
                    var questionId = Convert.ToInt32(row.Cells["QuestionId"].Value);
                    Question question = QuestionDAO.getQuestionById(questionId);
                    subjectId = question.SubjectId;
                    questions.Add(question);
                }
                frmAddTo frmAddTo = new frmAddTo {
                    questions = questions,
                    UserLogged = UserLogged,
                    subjectId = subjectId,
                    currentExam = (cbExam.SelectedItem as Exam).ExamId
                };

                frmAddTo.ShowDialog();
            }
        }
    }
}
