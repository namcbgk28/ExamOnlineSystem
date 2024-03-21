using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EOSProject {
    public partial class frmResultDetail : Form {

        public Prn211ProjectContext context = new Prn211ProjectContext();
        public int testId { get; set; }
        public string userId { get; set; }

        public string key = "";

        public frmResultDetail() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmResultDetail_Load(object sender, EventArgs e) {
            loadData();
        }

        private void loadData() {

            var data = (from td in context.TestDetails
                        join q in context.Questions on td.QuestionId equals q.QuestionId
                        join o1 in context.Options on q.QuestionId equals o1.QuestionId
                        join oc in context.Options on td.OptionChoosen equals oc.OptionId into chosenOptions
                        from chosenOption in chosenOptions.DefaultIfEmpty()
                        where td.UserId == userId && o1.RightAnswer == true && testId == td.TestId
                        select new {
                            td.QuestionId,
                            q.QuestionContent,
                            chosen_option_content = td.OptionChoosen == 0 ? "Not Answered" : chosenOption.OptionContent,
                            right_option_content = o1.OptionContent,
                            Score = td.OptionChoosen == 0 ? 0 : (chosenOption.OptionContent == o1.OptionContent ? 1 : 0)
                        }).ToList();

            if (key != "") {
                data = data.Where(x => x.QuestionContent.Contains(key)).ToList();
            }

            dgvDetail.DataSource = data;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e) {
            key = tbSearch.Text;
            loadData();
        }
    }
}
