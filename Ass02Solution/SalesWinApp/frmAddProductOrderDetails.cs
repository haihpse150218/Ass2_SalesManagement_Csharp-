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
    public partial class frmAddProductOrderDetails : Form
    {
        public frmAddProductOrderDetails()
        {
            InitializeComponent();
            LoadComboBoxProduct();
        }

        ProductRepository productRepository = new ProductRepository();
        private void LoadComboBoxProduct()
        {

            List<ProductObject> list = productRepository.GetProductObjects();
            BindingList<string> data = new BindingList<string>(list.Select(p => p.ProductName).ToList());
            cbProducts.DataSource = data;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAddOrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbProducts_Click(object sender, EventArgs e)
        {
           
        }
    }
}
