using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Models;
using BusinessObject;
using DataAccess.Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        void LoadList()
        {
            List<MemberObject> listMember = MemberRepository.Instance.GetMemberList();
            BindingList<MemberObject> bindingList = new BindingList<MemberObject>(listMember);
            dgvManagerMembers.DataSource = bindingList;
            dgvManagerMembers.AutoResizeColumns();
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.ShowDialog();
            LoadList();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Are you sure to Delete this Member ?", "Delete Member", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (FStore2Context db = new FStore2Context())
                    {
                        MemberObject removeMember = dgvManagerMembers.CurrentRow.DataBoundItem as MemberObject;
                        var result = db.Members.Where(m => m.MemberId == removeMember.MemberId).FirstOrDefault();
                    try
                    {
                        db.Members.Remove(result);
                        db.SaveChanges();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error When Delete: \n" + ex);
                    }
                        
                    }
                }
            

            LoadList();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            MemberObject member = null;
            member = dgvManagerMembers.CurrentRow.DataBoundItem as MemberObject;
            frmEditMember frmEditMember = new frmEditMember(member);
            frmEditMember.ShowDialog();
            LoadList();
        }

    }
}
