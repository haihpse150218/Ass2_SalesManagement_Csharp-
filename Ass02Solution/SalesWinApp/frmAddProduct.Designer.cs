namespace SalesWinApp
{
    partial class frmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.cbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.txtProductNameAdd = new System.Windows.Forms.TextBox();
            this.txtWeightAdd = new System.Windows.Forms.TextBox();
            this.txtPriceAdd = new System.Windows.Forms.MaskedTextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnCloseAddProduct = new System.Windows.Forms.Button();
            this.txtUnitsInStockAdd = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUnitsInStockAdd);
            this.panel1.Controls.Add(this.btnCloseAddProduct);
            this.panel1.Controls.Add(this.btnCreateProduct);
            this.panel1.Controls.Add(this.txtPriceAdd);
            this.panel1.Controls.Add(this.txtWeightAdd);
            this.panel1.Controls.Add(this.txtProductNameAdd);
            this.panel1.Controls.Add(this.cbCategoryAdd);
            this.panel1.Controls.Add(this.lbUnitslnStock);
            this.panel1.Controls.Add(this.lbUnitPrice);
            this.panel1.Controls.Add(this.lbWeight);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.lbCategoryId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 337);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(34, 226);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitslnStock.TabIndex = 9;
            this.lbUnitslnStock.Text = "Units ln Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(34, 177);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 8;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(34, 128);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(34, 79);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(34, 29);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(55, 15);
            this.lbCategoryId.TabIndex = 5;
            this.lbCategoryId.Text = "Category";
            // 
            // cbCategoryAdd
            // 
            this.cbCategoryAdd.FormattingEnabled = true;
            this.cbCategoryAdd.Location = new System.Drawing.Point(177, 26);
            this.cbCategoryAdd.Name = "cbCategoryAdd";
            this.cbCategoryAdd.Size = new System.Drawing.Size(198, 23);
            this.cbCategoryAdd.TabIndex = 10;
            // 
            // txtProductNameAdd
            // 
            this.txtProductNameAdd.Location = new System.Drawing.Point(177, 71);
            this.txtProductNameAdd.Name = "txtProductNameAdd";
            this.txtProductNameAdd.Size = new System.Drawing.Size(198, 23);
            this.txtProductNameAdd.TabIndex = 11;
            // 
            // txtWeightAdd
            // 
            this.txtWeightAdd.Location = new System.Drawing.Point(177, 120);
            this.txtWeightAdd.Name = "txtWeightAdd";
            this.txtWeightAdd.Size = new System.Drawing.Size(198, 23);
            this.txtWeightAdd.TabIndex = 12;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(177, 169);
            this.txtPriceAdd.Mask = "000000000.00";
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(198, 23);
            this.txtPriceAdd.TabIndex = 13;
            this.txtPriceAdd.Text = "0";
            this.txtPriceAdd.ValidatingType = typeof(int);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(177, 284);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(75, 31);
            this.btnCreateProduct.TabIndex = 15;
            this.btnCreateProduct.Text = "Create";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnCloseAddProduct
            // 
            this.btnCloseAddProduct.Location = new System.Drawing.Point(300, 284);
            this.btnCloseAddProduct.Name = "btnCloseAddProduct";
            this.btnCloseAddProduct.Size = new System.Drawing.Size(75, 31);
            this.btnCloseAddProduct.TabIndex = 16;
            this.btnCloseAddProduct.Text = "Close";
            this.btnCloseAddProduct.UseVisualStyleBackColor = true;
            this.btnCloseAddProduct.Click += new System.EventHandler(this.btnCloseAddProduct_Click);
            // 
            // txtUnitsInStockAdd
            // 
            this.txtUnitsInStockAdd.Location = new System.Drawing.Point(177, 218);
            this.txtUnitsInStockAdd.Mask = "000000000";
            this.txtUnitsInStockAdd.Name = "txtUnitsInStockAdd";
            this.txtUnitsInStockAdd.Size = new System.Drawing.Size(198, 23);
            this.txtUnitsInStockAdd.TabIndex = 17;
            this.txtUnitsInStockAdd.Text = "0";
            this.txtUnitsInStockAdd.ValidatingType = typeof(int);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 361);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUnitslnStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Button btnCloseAddProduct;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.MaskedTextBox txtPriceAdd;
        private System.Windows.Forms.TextBox txtWeightAdd;
        private System.Windows.Forms.TextBox txtProductNameAdd;
        private System.Windows.Forms.ComboBox cbCategoryAdd;
        private System.Windows.Forms.MaskedTextBox txtUnitsInStockAdd;
    }
}