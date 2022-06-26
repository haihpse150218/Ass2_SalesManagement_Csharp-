namespace SalesWinApp
{
    partial class frmEditProduct
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
            this.txtUnitsInStockEdit = new System.Windows.Forms.MaskedTextBox();
            this.txtPriceEdit = new System.Windows.Forms.MaskedTextBox();
            this.txtWeightEdit = new System.Windows.Forms.TextBox();
            this.txtProductNameEdit = new System.Windows.Forms.TextBox();
            this.cbCategoryEdit = new System.Windows.Forms.ComboBox();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryId = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductIdEdit = new System.Windows.Forms.TextBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnCloseEditProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseEditProduct);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.txtProductIdEdit);
            this.panel1.Controls.Add(this.lbProductId);
            this.panel1.Controls.Add(this.txtUnitsInStockEdit);
            this.panel1.Controls.Add(this.txtPriceEdit);
            this.panel1.Controls.Add(this.txtWeightEdit);
            this.panel1.Controls.Add(this.txtProductNameEdit);
            this.panel1.Controls.Add(this.cbCategoryEdit);
            this.panel1.Controls.Add(this.lbUnitslnStock);
            this.panel1.Controls.Add(this.lbUnitPrice);
            this.panel1.Controls.Add(this.lbWeight);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.lbCategoryId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 337);
            this.panel1.TabIndex = 0;
            // 
            // txtUnitsInStockEdit
            // 
            this.txtUnitsInStockEdit.Location = new System.Drawing.Point(178, 252);
            this.txtUnitsInStockEdit.Mask = "000000000";
            this.txtUnitsInStockEdit.Name = "txtUnitsInStockEdit";
            this.txtUnitsInStockEdit.Size = new System.Drawing.Size(198, 23);
            this.txtUnitsInStockEdit.TabIndex = 27;
            this.txtUnitsInStockEdit.Text = "0";
            this.txtUnitsInStockEdit.ValidatingType = typeof(int);
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(178, 203);
            this.txtPriceEdit.Mask = "000000000.00";
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(198, 23);
            this.txtPriceEdit.TabIndex = 26;
            this.txtPriceEdit.Text = "0";
            this.txtPriceEdit.ValidatingType = typeof(int);
            // 
            // txtWeightEdit
            // 
            this.txtWeightEdit.Location = new System.Drawing.Point(178, 154);
            this.txtWeightEdit.Name = "txtWeightEdit";
            this.txtWeightEdit.Size = new System.Drawing.Size(198, 23);
            this.txtWeightEdit.TabIndex = 25;
            // 
            // txtProductNameEdit
            // 
            this.txtProductNameEdit.Location = new System.Drawing.Point(178, 105);
            this.txtProductNameEdit.Name = "txtProductNameEdit";
            this.txtProductNameEdit.Size = new System.Drawing.Size(198, 23);
            this.txtProductNameEdit.TabIndex = 24;
            // 
            // cbCategoryEdit
            // 
            this.cbCategoryEdit.FormattingEnabled = true;
            this.cbCategoryEdit.Location = new System.Drawing.Point(178, 60);
            this.cbCategoryEdit.Name = "cbCategoryEdit";
            this.cbCategoryEdit.Size = new System.Drawing.Size(198, 23);
            this.cbCategoryEdit.TabIndex = 23;
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(35, 260);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(79, 15);
            this.lbUnitslnStock.TabIndex = 22;
            this.lbUnitslnStock.Text = "Units ln Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(35, 211);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 21;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(35, 162);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(35, 113);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 19;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(35, 63);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(55, 15);
            this.lbCategoryId.TabIndex = 18;
            this.lbCategoryId.Text = "Category";
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(35, 22);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(62, 15);
            this.lbProductId.TabIndex = 28;
            this.lbProductId.Text = "Product Id";
            // 
            // txtProductIdEdit
            // 
            this.txtProductIdEdit.Location = new System.Drawing.Point(178, 22);
            this.txtProductIdEdit.Name = "txtProductIdEdit";
            this.txtProductIdEdit.ReadOnly = true;
            this.txtProductIdEdit.Size = new System.Drawing.Size(198, 23);
            this.txtProductIdEdit.TabIndex = 29;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(178, 296);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 28);
            this.btnEditProduct.TabIndex = 30;
            this.btnEditProduct.Text = "Update";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnCloseEditProduct
            // 
            this.btnCloseEditProduct.Location = new System.Drawing.Point(301, 296);
            this.btnCloseEditProduct.Name = "btnCloseEditProduct";
            this.btnCloseEditProduct.Size = new System.Drawing.Size(75, 28);
            this.btnCloseEditProduct.TabIndex = 31;
            this.btnCloseEditProduct.Text = "Close";
            this.btnCloseEditProduct.UseVisualStyleBackColor = true;
            this.btnCloseEditProduct.Click += new System.EventHandler(this.btnCloseEditProduct_Click);
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 361);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProductIdEdit;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.MaskedTextBox txtUnitsInStockEdit;
        private System.Windows.Forms.MaskedTextBox txtPriceEdit;
        private System.Windows.Forms.TextBox txtWeightEdit;
        private System.Windows.Forms.TextBox txtProductNameEdit;
        private System.Windows.Forms.ComboBox cbCategoryEdit;
        private System.Windows.Forms.Label lbUnitslnStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryId;
        private System.Windows.Forms.Button btnCloseEditProduct;
        private System.Windows.Forms.Button btnEditProduct;
    }
}