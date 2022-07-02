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
        public frmOrders(int orderId)
        {
            InitializeComponent();
            tabOrders.SelectedIndex = 1;
            loadViewDetails(orderId);
            dgvOrderDetails.AutoResizeColumns();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            OrderObject order = null;
            
            if(dgvOrder.CurrentRow == null)
            {
                MessageBox.Show("Choose a order before viewing");
            }
            else
            {
                order = dgvOrder.CurrentRow.DataBoundItem as OrderObject;
                tabOrders.SelectedIndex = 1;
                txtOderIdDetails.Text = order.OrderId.ToString();
                txtMemberIdDetails.Text = order.MemberId.ToString();
                dtOrderDateDetails.Value = order.OrderDate;
                if(order.RequiredDate == null)
                {
                    dtRequiredDate.CustomFormat = "";
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
                loadViewDetails(order.OrderId);

            }
            dgvOrderDetails.AutoResizeColumns();
        }

        public void loadViewDetails(int orderId)
        {
            List<OrderDetailObjec> orderDetailObjecs = OrderDetailRepository.Instance.GetOrderDetailObjecstByOrderId(orderId);
            BindingList<OrderDetailObjec> databinding = new BindingList<OrderDetailObjec>(orderDetailObjecs);
            dgvOrderDetails.DataSource = databinding;
        }
       
        private void btnSortSalesDescending_Click(object sender, EventArgs e)
        {
            List<OrderObject> list = new List<OrderObject>();
            for (int row = 0; row < dgvOrder.Rows.Count; row++)
            {
                OrderObject order = dgvOrder.Rows[row].DataBoundItem as OrderObject;
                list.Add(order);
            }
                List<OrderObject> listSorted =  OrderRepository.Instance.sortDecByTotal(list);
            BindingList<OrderObject> databinding = new BindingList<OrderObject>(listSorted);
            dgvOrder.DataSource = databinding;

        }
        

        private void btnCreateReport_Click(object sender, EventArgs e)
        {

            tabOrders.SelectedIndex = 2;
            listViewReport.Columns.Add("Order Id").AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewReport.Columns.Add("Member Id").AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewReport.Columns.Add("Total").AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            double total = 0;
            
           
            for (int row = 0; row < dgvOrder.Rows.Count; row++)
            {
                OrderObject order = dgvOrder.Rows[row].DataBoundItem as OrderObject;
                if(order != null)
                {
                    ListViewItem colOrderId = new ListViewItem();
                    colOrderId.Text = order.OrderId.ToString();
                    colOrderId.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.MemberId.ToString() });
                    colOrderId.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.Total.ToString() });
                    total += order.Total;
                    listViewReport.Items.Add(colOrderId);
                }
                
            }
            ListViewItem brackLine = new ListViewItem();
            brackLine.Text = "=====";
            brackLine.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "=====" });
            brackLine.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "=====" });
            listViewReport.Items.Add(brackLine);

            ListViewItem sum = new ListViewItem();
            sum.Text = "Sum";
            sum.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            sum.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = total.ToString() });
            listViewReport.Items.Add(sum);
            listViewReport.Show();
            listViewReport.View = View.Details;
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
                dgvOrder.AutoResizeColumns();

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
            int orderId = int.Parse(txtOderIdDetails.Text);
            frmAddProductOrderDetails frmAddProductOrderDetails = new frmAddProductOrderDetails(orderId);
            frmAddProductOrderDetails.ShowDialog();
            loadViewDetails(orderId);
        }
        
    }
}
