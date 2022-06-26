using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.ShowDialog();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            
        }


        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.ShowDialog();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {

        }

        private void btnEditMember_Click_1(object sender, EventArgs e)
        {
            frmEditMember frmEditMember = new frmEditMember();
            frmEditMember.ShowDialog();
        }
    }
}
