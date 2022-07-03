using System;
using System.Collections.Generic;
using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductObject product = new ProductObject
                {
                    CategoryId = Convert.ToInt32(cbCategoryAdd.Text),
                    ProductName = txtProductNameAdd.Text.Trim(),
                    Weight = txtWeightAdd.Text.Trim(),
                    UnitPrice = Convert.ToDecimal(txtPriceAdd.Text),
                    UnitslnStock = Convert.ToInt32(txtUnitsInStockAdd.Text),
                };
                FStore2Context db = new FStore2Context();

                if (product == null)
                {
                    MessageBox.Show("Please enter all information.");
                }
                else
                {
                    var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<ProductObject, Product>()
                    );
                    //Using AutoMapper
                    var mapper = new Mapper(config);
                    Product pro = mapper.Map<Product>(product);
                    db.Products.Add(pro);
                    db.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Create new member error!\n Please enter correct information.");
            }

        }

        private void btnCloseAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
