using BusinessObject;
using DataAccess.Repository;
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
            OrderObject order = null;
            order = dgvOrder.CurrentRow.DataBoundItem as OrderObject;
            if(order == null)
            {
                MessageBox.Show("Choose a order before viewing");
            }
            else
            {
                tabOrders.SelectedIndex = 1;
                txtOderIdDetails.Text = order.OrderId.ToString();
                txtMemberIdDetails.Text = order.MemberId.ToString();
                dtOrderDateDetails.Value = order.OrderDate;
                if(order.RequiredDate == null)
                {
                    dtRequiredDate.CustomFormat = " ";
                }
                else
                {
                    dtRequiredDate.Value = Convert.ToDateTime(order.RequiredDate);
                }
                if (order.ShippedDate == null)
                {
                    dtShippedDate.CustomFormat = " ";
                }
                else
                {
                    dtShippedDate.Value = Convert.ToDateTime(order.ShippedDate);
                }
                List<ProductObject> products = new List<ProductObject>();
                ProductRepository productRepository = new ProductRepository();
                products = productRepository.getProductObjectsByOrderId(order.OrderId);
                BindingList<ProductObject> databinding = new BindingList<ProductObject>(products);
                dgvOrderDetails.DataSource = databinding;
                dgvOrderDetails.AutoResizeColumns(); 
            }
            

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
            DateTime fromDate,toDate;
            fromDate = dtFromDateOrder.Value;
            toDate = dtToDateOrder.Value;
            List<OrderObject> listOrder = 
                OrderRepository.Instance.GetListOrderByRangeDate(fromDate, toDate, frmLogin.User);

            if (listOrder.Count == 0)
            {
                dgvOrder.Columns.Add("Result", "Result");

                dgvOrder.Rows.Add("No Result");
            }
            else
            {
                BindingList<OrderObject> bindingList = new BindingList<OrderObject>(listOrder);
                dgvOrder.DataSource = bindingList;
                
            }
            dgvOrder.AutoResizeColumns();

        }
        private void btnLoadAllOrder_Click(object sender, EventArgs e)
        {
            List<OrderObject> listOrder =
               OrderRepository.Instance.GetOrderObjectsByUser(frmLogin.User);
            if (listOrder.Count == 0)
            {
                dgvOrder.Columns.Add("Result", "Result");
                dgvOrder.Rows.Add("No Result");
            }
            else
            {
                BindingList<OrderObject> bindingList = new BindingList<OrderObject>(listOrder);
                dgvOrder.DataSource = bindingList;
            }
            dgvOrder.AutoResizeColumns();
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            frmAddProductOrderDetails frmAddProductOrderDetails = new frmAddProductOrderDetails();
            frmAddProductOrderDetails.ShowDialog();
        }
        
    }
}
