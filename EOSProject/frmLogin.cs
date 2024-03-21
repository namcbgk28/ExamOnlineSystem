using System.Diagnostics.Metrics;
using BusinessObject;
using DataAccess;
using DataAccess;

namespace EOSProject {
    public partial class frmLogin : Form {

        UserDAO ud = new UserDAO();

        public static User UserLogged = null;
        public frmLogin() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            txtEmail.Text = "tiennq123@fpt.edu.vn";
            txtPassword.Text = "12345678";
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User user = ud.GetUserByEmailAndPassword(email, password);
            if(user != null) {
                UserLogged = user;

                frmMain frmMain = new frmMain {
                    UserLogged = UserLogged
                };

                this.Hide();
                frmMain.Show();
            }
            else {
                MessageBox.Show("Wrong Email or Password!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
    }
}
