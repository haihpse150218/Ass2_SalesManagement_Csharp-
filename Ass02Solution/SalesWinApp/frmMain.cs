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

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }



        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                if(form.Name == "frmMembers")
                {
                    form.Show();
                }
                else
                {
                    form.Close();
                }
            }
            if (this.MdiChildren.Count() == 0)
            {
                frmMembers frmMembers = new frmMembers();
                frmMembers.MdiParent = this;
                frmMembers.Dock = DockStyle.Fill;
                frmMembers.Show();
            }

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmProducts")
                {
                    if(frmLogin.User.Role==1)
                    {
                        MessageBox.Show("You can't access to this tab!");
                    }
                    else
                    {
                        form.Show();
                    }
                    
                }
                else
                {
                    form.Close();
                }
            }
            if (this.MdiChildren.Count() == 0)
            {
                if (frmLogin.User.Role == 1)
                {
                    MessageBox.Show("You can't access to this tab!");
                }
                else
                {
                    frmProducts frmProducts = new frmProducts();
                    frmProducts.MdiParent = this;
                    frmProducts.Dock = DockStyle.Fill;
                    frmProducts.Show();
                }
                
            }
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == "frmOrders")
                {
                    
                    form.Show();
                }
                else
                {
                    form.Close();
                }
            }
            if (this.MdiChildren.Count() == 0)
            {
                frmOrders frmOrders = new frmOrders();
                frmOrders.MdiParent = this;
                frmOrders.Dock = DockStyle.Fill;
                frmOrders.Show();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
