using System;
using BusinessObject;
using DataAccess.Repository;
using System.Collections.Generic;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            loadProductList();
        }

        void loadProductList()
        {
            //IProductRepository productRepository = ProductRepository();
            List<ProductObject> listProduct = ProductRepository.Instance.GetAllProduct();
            BindingList<ProductObject> bindingList = new BindingList<ProductObject>(listProduct);
            dgvProduct.DataSource = bindingList;
            dgvProduct.AutoResizeColumns();
        }
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.ShowDialog();
            loadProductList();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            ProductObject product = null;
            product = dgvProduct.CurrentRow.DataBoundItem as ProductObject;
            frmEditProduct frmEditProduct = new frmEditProduct(product);
            frmEditProduct.ShowDialog();
            loadProductList();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Product ?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FStore2Context db = new FStore2Context())
                {
                    ProductObject removeProduct = dgvProduct.CurrentRow.DataBoundItem as ProductObject;
                    var result = db.Products.Where(m => m.ProductId == removeProduct.ProductId).FirstOrDefault();
                    try
                    {
                        db.Products.Remove(result);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("You can't delete it because Order have reference to it!");
                    }
                    
                }
            }
            loadProductList();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            List<ProductObject> result = new List<ProductObject>();
            FStore2Context db = new FStore2Context();
            string text = txtSearchBox.Text;
            string typeOfSearch = cbSearchSelect.Text.Trim();
            bool flag = false;
            switch (typeOfSearch)
            {
                case "Search By Product Id":
                    try
                    {
                        int searchID = Convert.ToInt32(txtSearchBox.Text);
                        foreach(Product pro in db.Products)
                        {
                            if(pro.ProductId == searchID)
                            {
                                var config = new MapperConfiguration(cfg =>
                                   cfg.CreateMap<Product, ProductObject>()
                                );
                                var mapper = new Mapper(config);
                                ProductObject p = mapper.Map<ProductObject>(pro);
                                result.Add(p);
                                flag = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong type ID");
                    }
                    break;
                case "Search By Product Name":
                    try
                    {
                        string name = txtSearchBox.Text;
                        foreach (Product pro in db.Products)
                        {
                            if (pro.ProductName == name)
                            {
                                var config = new MapperConfiguration(cfg =>
                                   cfg.CreateMap<Product, ProductObject>()
                                );
                                var mapper = new Mapper(config);
                                ProductObject p = mapper.Map<ProductObject>(pro);
                                result.Add(p);
                                flag = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong type name");
                    }
                    break;
                case "Search By Unit In Stock":
                    try
                    {
                        int stock = Convert.ToInt32(txtSearchBox.Text);
                        foreach (Product pro in db.Products)
                        {
                            if (pro.UnitslnStock == stock)
                            {
                                var config = new MapperConfiguration(cfg =>
                                   cfg.CreateMap<Product, ProductObject>()
                                );
                                var mapper = new Mapper(config);
                                ProductObject p = mapper.Map<ProductObject>(pro);
                                result.Add(p);
                                flag = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong type Units in stock");
                    }
                    break;
                case "Search By Unit Price":
                    try
                    {
                        decimal price = Convert.ToDecimal(txtSearchBox.Text);
                        foreach (Product pro in db.Products)
                        {
                            if (pro.UnitPrice == price)
                            {
                                var config = new MapperConfiguration(cfg =>
                                   cfg.CreateMap<Product, ProductObject>()
                                );
                                var mapper = new Mapper(config);
                                ProductObject p = mapper.Map<ProductObject>(pro);
                                result.Add(p);
                                flag = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong type Price");
                    }
                    break;
            }
            if(result.Count == 0 || flag == false)
            {
                MessageBox.Show("No result");
                loadProductList();
            }
            else
            {
                BindingList<ProductObject> source = new BindingList<ProductObject>(result);
                dgvProduct.DataSource = source;
            }
        }
    }
}
