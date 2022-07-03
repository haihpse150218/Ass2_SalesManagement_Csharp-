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
            this.txtUnitsInStockAdd = new System.Windows.Forms.MaskedTextBox();
            this.btnCloseAddProduct = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.txtPriceAdd = new System.Windows.Forms.MaskedTextBox();
            this.txtWeightAdd = new System.Windows.Forms.TextBox();
            this.txtProductNameAdd = new System.Windows.Forms.TextBox();
            this.cbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUnitsInStockAdd
            // 
            this.txtUnitsInStockAdd.Location = new System.Drawing.Point(202, 291);
            this.txtUnitsInStockAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitsInStockAdd.Mask = "000000000";
            this.txtUnitsInStockAdd.Name = "txtUnitsInStockAdd";
            this.txtUnitsInStockAdd.Size = new System.Drawing.Size(226, 27);
            this.txtUnitsInStockAdd.TabIndex = 17;
            this.txtUnitsInStockAdd.Text = "0";
            this.txtUnitsInStockAdd.ValidatingType = typeof(int);
            // 
            // btnCloseAddProduct
            // 
            this.btnCloseAddProduct.Location = new System.Drawing.Point(343, 379);
            this.btnCloseAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseAddProduct.Name = "btnCloseAddProduct";
            this.btnCloseAddProduct.Size = new System.Drawing.Size(86, 41);
            this.btnCloseAddProduct.TabIndex = 16;
            this.btnCloseAddProduct.Text = "Close";
            this.btnCloseAddProduct.UseVisualStyleBackColor = true;
            this.btnCloseAddProduct.Click += new System.EventHandler(this.btnCloseAddProduct_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(202, 379);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(86, 41);
            this.btnCreateProduct.TabIndex = 15;
            this.btnCreateProduct.Text = "Create";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(202, 225);
            this.txtPriceAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceAdd.Mask = "000000000.00";
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(226, 27);
            this.txtPriceAdd.TabIndex = 13;
            this.txtPriceAdd.Text = "0";
            this.txtPriceAdd.ValidatingType = typeof(int);
            // 
            // txtWeightAdd
            // 
            this.txtWeightAdd.Location = new System.Drawing.Point(202, 160);
            this.txtWeightAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeightAdd.Name = "txtWeightAdd";
            this.txtWeightAdd.Size = new System.Drawing.Size(226, 27);
            this.txtWeightAdd.TabIndex = 12;
            // 
            // txtProductNameAdd
            // 
            this.txtProductNameAdd.Location = new System.Drawing.Point(202, 95);
            this.txtProductNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductNameAdd.Name = "txtProductNameAdd";
            this.txtProductNameAdd.Size = new System.Drawing.Size(226, 27);
            this.txtProductNameAdd.TabIndex = 11;
            // 
            // cbCategoryAdd
            // 
            this.cbCategoryAdd.FormattingEnabled = true;
            this.cbCategoryAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCategoryAdd.Location = new System.Drawing.Point(202, 35);
            this.cbCategoryAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategoryAdd.Name = "cbCategoryAdd";
            this.cbCategoryAdd.Size = new System.Drawing.Size(226, 28);
            this.cbCategoryAdd.TabIndex = 10;
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(39, 301);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(98, 20);
            this.lbUnitslnStock.TabIndex = 9;
            this.lbUnitslnStock.Text = "Units ln Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(39, 236);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 8;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(39, 171);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(39, 105);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(39, 39);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(69, 20);
            this.lbCategoryId.TabIndex = 5;
            this.lbCategoryId.Text = "Category";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 481);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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