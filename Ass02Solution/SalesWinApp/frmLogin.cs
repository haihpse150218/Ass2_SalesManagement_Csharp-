using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            if (Login(email, password))
            {
                frmMain frmMain = new frmMain(); ;
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
        }
        bool Login(string email, string password)
        {
            if (email == null)
            {
                email = "";
            }
            if (password == null)
            {
                password = "";
            }
            bool flag = false;
            string msg = null;
            flag = MemberRepository.Instance.Login(email, password, out msg);
            if (msg != null)
            {
                MessageBox.Show(msg);
            }
            return flag;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sur to exit?", "Exit Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
