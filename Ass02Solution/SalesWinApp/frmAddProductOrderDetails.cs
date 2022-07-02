using AutoMapper;
using BusinessObject;
using DataAccess.Models;
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
    public partial class frmAddProductOrderDetails : Form
    {

        List<ProductObject> listProduct = null;
        List<OrderDetailObjec> listOrderDetails = null;
   
        int OrderId;
        public frmAddProductOrderDetails()
        {
            listProduct = new List<ProductObject>();
            listOrderDetails = new List<OrderDetailObjec>();
      
            InitializeComponent();
            LoadComboBoxProduct();
        }
        public frmAddProductOrderDetails(int orderId)
        {
            OrderId = orderId;
            listProduct = new List<ProductObject>();
            listOrderDetails = OrderDetailRepository.Instance.GetOrderDetailObjecstByOrderId(orderId);
  
            InitializeComponent();
            LoadComboBoxProduct();
            LoadViews();
        }
        ProductRepository productRepository = new ProductRepository();
        private void LoadComboBoxProduct()
        {

            List<ProductObject> list = productRepository.GetProductObjects();
            BindingList<ProductObject> source = new BindingList<ProductObject>(list);
            cbProducts.DataSource = source;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductObject product = cbProducts.SelectedItem as ProductObject;
            if (product == null)
            {
                MessageBox.Show("Selecting Product before add");
            }
            else
            {
                listProduct.Add(product);
                int quantity = (int)nmQuantity.Value;
                OrderDetailObjec order = new OrderDetailObjec();
                // get infor
                order.ProductId = product.ProductId;
                order.OrderId = OrderId;
                order.Quantity = quantity;
                order.UnitPrice = product.UnitPrice;
                foreach (OrderDetailObjec item in listOrderDetails)
                {
                    if (order.ProductId == item.ProductId && item.OrderId == item.OrderId)
                    {
                        listOrderDetails.Remove(item);
                        break;
                    }
                }
                    //add List Order
                listOrderDetails.Add(order);
                LoadViews();


            }
        }

        private void LoadViews()
        {
            BindingList<OrderDetailObjec> sourceProduct = new BindingList<OrderDetailObjec>(listOrderDetails);
            dgvAddProductOrderDetails.DataSource = sourceProduct;
            dgvAddProductOrderDetails.AutoResizeColumns();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (dgvAddProductOrderDetails.CurrentRow == null)
            {
                MessageBox.Show("Choose row to remove");
            }
            else
            {
                OrderDetailObjec removeOrder = dgvAddProductOrderDetails.CurrentRow.DataBoundItem as OrderDetailObjec;
                listOrderDetails.Remove(removeOrder);
                LoadViews();
            }


        }

        private void btnSaveAddOrderDetails_Click(object sender, EventArgs e)
        {
            FStore2Context db = new FStore2Context();
            if (listOrderDetails.Count == 0)
            {
                if(MessageBox.Show("Need have one or more product") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                var config = new MapperConfiguration(
                       cfg => cfg.CreateMap<OrderDetailObjec, OrderDetail>());

                //Using AutoMapper
         
                var mapper = new Mapper(config);
                foreach (OrderDetail obj in db.OrderDetails.Where(x => x.OrderId == OrderId))
                {
                    db.OrderDetails.Attach(obj);
                    db.OrderDetails.Remove(obj);
                }
                foreach (OrderDetailObjec order in listOrderDetails)
                {
                    int pid = order.ProductId;
                    int oid = order.OrderId;
                    OrderDetail saveOrder = mapper.Map<OrderDetail>(order);
                    db.OrderDetails.Add(saveOrder);
                }
                db.SaveChanges();
                this.Close();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbProducts_Click(object sender, EventArgs e)
        {

        }

        private void cbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProductObject product = cbProducts.SelectedItem as ProductObject;
        }
    }
}
