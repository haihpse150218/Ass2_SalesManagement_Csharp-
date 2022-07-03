
﻿using BusinessObject;
using DataAccess.Repository;

using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {

        public static MemberObject User { get; set; }
        public frmLogin()
        {
            User = null;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            User = Login(email, password);
            if (User != null)

            {
                frmMain frmMain = new frmMain(); ;
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
        }

        MemberObject Login(string email, string password)

        {
            if (email == null)
            {
                email = "";
            }
            if (password == null)
            {
                password = "";
            }

            MemberObject user = null;
            string msg = null;
            user = MemberRepository.Instance.Login(email, password, out msg);

            if (msg != null)
            {
                MessageBox.Show(msg);
            }

            return user;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit Confirm", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
