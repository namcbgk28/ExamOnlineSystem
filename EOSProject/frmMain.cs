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

    public partial class frmMain : Form {
        public User UserLogged { get; set; }

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            if (UserLogged.RoleId == 1) {
                lbHello.Text = "Student: " + UserLogged.FullName;
                mnExam.Visible = false;
                mnResult.Visible = false;
                mnTest.Visible = false;
                lbGuide.Text = "Enter the exam code";
            }
            else if (UserLogged.RoleId == 2) {
                btnEnter.Visible = false;
                tbTestCode.Visible = false;
                lbHello.Text = "Welcome Back Mr." + UserLogged.FullName + "!";
            }
        }



        private void btnLogOut_Click(object sender, EventArgs e) {
            frmLogin frmLogin = new frmLogin();
            frmLogin.UserLogged = null;
            this.UserLogged = null;
            this.Close();
        }

        private void mnExam_Click(object sender, EventArgs e) {
            frmQuestionManagement frmQuestionManagement = new frmQuestionManagement {
                UserLogged = UserLogged
            };
            this.Hide();
            frmQuestionManagement.ShowDialog();
        }

        private void mnResult_Click(object sender, EventArgs e) {
            frmResultManagement frmResultManagement = new frmResultManagement {
                UserLogged = UserLogged
            };
            this.Hide();
            frmResultManagement.ShowDialog();
        }

        private void mnTest_Click(object sender, EventArgs e) {
            frmTestManagement frmTestManagement = new frmTestManagement {
                UserLogged = UserLogged
            };
            this.Hide();
            frmTestManagement.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            string testCode = tbTestCode.Text;
            Test test = TestDAO.GetTestByCode(testCode);
            string subjectId = test.SubjectId;
            int examId = (int)test.ExamId;


            if (!TestDAO.isTestCodeExist(testCode)) {
                MessageBox.Show("The test code is unavailable!");
            }
            else if (TestDAO.isTestCodeOff(testCode)) {
                MessageBox.Show("The test is turned off!");
            }
            else if (TestDAO.isUserDoneThisExam(UserLogged.UserId, examId, subjectId)) {
                MessageBox.Show("You have finished this exam.");
            }
            else if (!TestDAO.isTestHaveQuestion(testCode)) {
                MessageBox.Show("This test have no question.");
            }
            else {
                frmDoExam frm = new frmDoExam {
                    test = test,
                    UserLogged = UserLogged
                };
                this.Hide();
                frm.Show();
            }
        }
    }
}
