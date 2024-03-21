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
using Microsoft.EntityFrameworkCore;

namespace EOSProject {
    public partial class frmResultManagement : Form {

        public User UserLogged { get; set; }

        public Prn211ProjectContext context = new Prn211ProjectContext();
        public frmResultManagement() {
            InitializeComponent();
        }

        string subjectId = "";
        bool sort = true;
        string className = "";

        private void frmResultManagement_Load(object sender, EventArgs e) {
            LoadComboBox();
            LoadData();
        }

        private void LoadData() {

            subjectId = cbSubject.SelectedValue.ToString();

            double hi = ExamDAO.GetScore("HE176517", 1, "PRN211");

            var data = (from u in context.Users
                        join td in context.TestDetails on u.UserId equals td.UserId
                        join t in context.Tests on td.TestId equals t.TestId
                        join e in context.Exams on t.ExamId equals e.ExamId
                        join s in context.Subjects on t.SubjectId equals s.SubjectId
                        join cs in context.ClassSubjects on new { SubjectID = s.SubjectId, UserId = u.UserId } equals new { SubjectID = cs.SubjectId, UserId = cs.StudentId }
                        join c in context.Classes on cs.ClassId equals c.ClassId
                        select new {
                            UserId = u.UserId,
                            TestId = t.TestId,
                            ExamName = e.ExamName,
                            SubjectId = s.SubjectId,
                            ClassName = c.ClassName,
                            Score = ExamDAO.GetScore(u.UserId, e.ExamId, s.SubjectId)
                        }).Distinct().ToList();

            data = data.Where(x => x.SubjectId == subjectId).ToList();

            if (sort) {
                data = data.OrderBy(x => x.Score).ToList();
            }
            else {
                data = data.OrderByDescending(x => x.Score).ToList();
            }

            //className = cbClass.SelectedValue.ToString();

            data = data.Where(x => x.ClassName == className).ToList();


            dgvResult.DataSource = data;
        }

        private void LoadComboBox() {

            cbSubject.DataSource = (from t in context.Tests
                                    join s in context.Subjects on t.SubjectId equals s.SubjectId
                                    select new {
                                        SubjectId = t.SubjectId
                                    }
                                    ).Distinct().ToList();
            cbSubject.DisplayMember = "SubjectId";
            cbSubject.ValueMember = "SubjectId";


            cbClass.DataSource = context.Classes.Select(x => x.ClassName).Distinct().ToList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmResultManagement_FormClosed(object sender, FormClosedEventArgs e) {
            frmMain frmMain = new frmMain {
                UserLogged = UserLogged
            };

            frmMain.Show();
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e) {
            subjectId = cbSubject.SelectedValue.ToString();
            LoadData();
        }

        private void btnSort_Click(object sender, EventArgs e) {
            Button button = (Button)sender;

            if (button.Text == "Score ASC") {
                button.Text = "Score DESC";
                sort = false;
            }
            else {
                button.Text = "Score ASC";
                sort = true;
            }

            LoadData();
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnView_Click(object sender, EventArgs e) {
            if (dgvResult.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dgvResult.SelectedRows[0];
                string userId = dgvResult.SelectedRows[0].Cells["UserId"].FormattedValue.ToString();
                int testId = Convert.ToInt32(dgvResult.SelectedRows[0].Cells["TestId"].FormattedValue);

                frmResultDetail frmResultDetail = new frmResultDetail {
                    userId = userId,
                    testId = testId
                };

                frmResultDetail.ShowDialog();
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e) {
            className = cbClass.SelectedValue.ToString();
            LoadData();
        }
    }
}
