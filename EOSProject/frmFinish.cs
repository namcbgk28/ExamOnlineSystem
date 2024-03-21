using BusinessObject;
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
    public partial class frmFinish : Form {

        public Test test {  get; set; }

        public string submitTime { get; set; }
        public frmFinish() {
            InitializeComponent();
        }

        private void chbFinish_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnExist_Click(object sender, EventArgs e) => Application.Exit();

        private void frmFinish_Load(object sender, EventArgs e) {
            lbCountDown.Text = submitTime;
            lbTimeTest.Text = test.TestTime + "minutes";
            lbSubject.Text = test.SubjectId;
            lbNumQuestion.Text = test.NumberOfQuestion.ToString();
        }
    }
}
