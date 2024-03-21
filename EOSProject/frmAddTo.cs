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
    public partial class frmAddTo : Form {

        public List<Question> questions { get; set; }

        public User UserLogged { get; set; }

        public string subjectId { get; set; }

        public int currentExam { get; set; }
        public frmAddTo() {
            InitializeComponent();
        }

        private void frmAddTo_Load(object sender, EventArgs e) {
            lbSubject.Text = subjectId;

            List<Exam> exams = ExamDAO.getAllExams();
            for (int i = 0; i < exams.Count; i++) {
                if (exams[i].ExamId == currentExam) {
                    exams.Remove(exams[i]);
                }
            }
            cbExam.DataSource = exams;
            cbExam.DisplayMember = "ExamName";
            cbExam.ValueMember = "ExamId";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            foreach (var item in questions)
            {
                Question question = new Question {
                    QuestionId = QuestionDAO.getMaxId()+1,
                    QuestionContent = item.QuestionContent,
                    SubjectId = item.SubjectId,
                    ExamId = (cbExam.SelectedItem as Exam).ExamId
                };

                QuestionDAO.AddNewQuestion(question);

                List<Option> oldOptions = OptionDAO.getListAnswers(item.QuestionId);

                foreach (var oldOption in oldOptions)
                {
                    Option newOption = new Option {
                        QuestionId = question.QuestionId,
                        OptionContent = oldOption.OptionContent,
                        RightAnswer = oldOption.RightAnswer,
                        OptionId = OptionDAO.getMaxId() + 1
                    };

                    OptionDAO.AddNewOption(newOption);
                }
            }

            MessageBox.Show("Add successfully!");
            this.Close();

        }
    }
}
