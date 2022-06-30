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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            frmAddProductOrderDetails frmAddProductOrderDetails = new frmAddProductOrderDetails();
            frmAddProductOrderDetails.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.tabOrders.SelectedIndex = 1;
        }

        private void btnSortSalesDescending_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {

        }

        private void btLoadOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadAllOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
