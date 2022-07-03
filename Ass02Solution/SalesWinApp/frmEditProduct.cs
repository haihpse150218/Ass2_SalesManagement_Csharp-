using System;
using System.Collections.Generic;
using BusinessObject;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using AutoMapper;

namespace SalesWinApp
{
    public partial class frmEditProduct : Form
    {
        ProductObject productObj = new ProductObject();
        public frmEditProduct(ProductObject pro)
        {
            InitializeComponent();
            if(pro != null)
            {
                txtProductIdEdit.Text = pro.ProductId.ToString();
                cbCategoryEdit.Text = pro.CategoryId.ToString();
                txtProductNameEdit.Text = pro.ProductName;
                txtWeightEdit.Text = pro.Weight;
                txtPriceEdit.Text = pro.UnitPrice.ToString();
                txtUnitsInStockEdit.Text = pro.UnitPrice.ToString();

            }
        }


        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FStore2Context db = new FStore2Context();
            try
            {
                productObj.ProductId = Convert.ToInt32(txtProductIdEdit.Text.Trim());
                productObj.CategoryId = Convert.ToInt32(cbCategoryEdit.Text.Trim());
                productObj.ProductName = txtProductNameEdit.Text.Trim();
                productObj.Weight = txtWeightEdit.Text.Trim();
                productObj.UnitPrice = Convert.ToDecimal(txtPriceEdit.Text.Trim());
                productObj.UnitslnStock = Convert.ToInt32(txtUnitsInStockEdit.Text.Trim());

                var result = db.Products.Where(p => p.ProductId == productObj.ProductId).FirstOrDefault();
                result.CategoryId = productObj.CategoryId;
                result.ProductName = productObj.ProductName;
                result.Weight = productObj.Weight;
                result.UnitPrice = productObj.UnitPrice;
                result.UnitslnStock = productObj.UnitslnStock;

                db.SaveChanges();

                this.Close();
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Update Error");
            }
            

        }

        private void btnCloseEditProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
