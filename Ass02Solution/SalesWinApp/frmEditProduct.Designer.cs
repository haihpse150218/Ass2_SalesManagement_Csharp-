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
            this.btnCloseEditProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.txtProductIdEdit = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCloseEditProduct
            // 
            this.btnCloseEditProduct.Location = new System.Drawing.Point(344, 395);
            this.btnCloseEditProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseEditProduct.Name = "btnCloseEditProduct";
            this.btnCloseEditProduct.Size = new System.Drawing.Size(86, 37);
            this.btnCloseEditProduct.TabIndex = 31;
            this.btnCloseEditProduct.Text = "Close";
            this.btnCloseEditProduct.UseVisualStyleBackColor = true;
            this.btnCloseEditProduct.Click += new System.EventHandler(this.btnCloseEditProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(203, 395);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(86, 37);
            this.btnEditProduct.TabIndex = 30;
            this.btnEditProduct.Text = "Update";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // txtProductIdEdit
            // 
            this.txtProductIdEdit.Location = new System.Drawing.Point(203, 29);
            this.txtProductIdEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductIdEdit.Name = "txtProductIdEdit";
            this.txtProductIdEdit.ReadOnly = true;
            this.txtProductIdEdit.Size = new System.Drawing.Size(226, 27);
            this.txtProductIdEdit.TabIndex = 29;
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(40, 29);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(77, 20);
            this.lbProductId.TabIndex = 28;
            this.lbProductId.Text = "Product Id";
            // 
            // txtUnitsInStockEdit
            // 
            this.txtUnitsInStockEdit.Location = new System.Drawing.Point(203, 336);
            this.txtUnitsInStockEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitsInStockEdit.Mask = "000000000";
            this.txtUnitsInStockEdit.Name = "txtUnitsInStockEdit";
            this.txtUnitsInStockEdit.Size = new System.Drawing.Size(226, 27);
            this.txtUnitsInStockEdit.TabIndex = 27;
            this.txtUnitsInStockEdit.Text = "0";
            this.txtUnitsInStockEdit.ValidatingType = typeof(int);
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(203, 271);
            this.txtPriceEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceEdit.Mask = "000000000.00";
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(226, 27);
            this.txtPriceEdit.TabIndex = 26;
            this.txtPriceEdit.Text = "0";
            this.txtPriceEdit.ValidatingType = typeof(int);
            // 
            // txtWeightEdit
            // 
            this.txtWeightEdit.Location = new System.Drawing.Point(203, 205);
            this.txtWeightEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeightEdit.Name = "txtWeightEdit";
            this.txtWeightEdit.Size = new System.Drawing.Size(226, 27);
            this.txtWeightEdit.TabIndex = 25;
            // 
            // txtProductNameEdit
            // 
            this.txtProductNameEdit.Location = new System.Drawing.Point(203, 140);
            this.txtProductNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductNameEdit.Name = "txtProductNameEdit";
            this.txtProductNameEdit.Size = new System.Drawing.Size(226, 27);
            this.txtProductNameEdit.TabIndex = 24;
            // 
            // cbCategoryEdit
            // 
            this.cbCategoryEdit.FormattingEnabled = true;
            this.cbCategoryEdit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCategoryEdit.Location = new System.Drawing.Point(203, 80);
            this.cbCategoryEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategoryEdit.Name = "cbCategoryEdit";
            this.cbCategoryEdit.Size = new System.Drawing.Size(226, 28);
            this.cbCategoryEdit.TabIndex = 23;
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(40, 347);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(98, 20);
            this.lbUnitslnStock.TabIndex = 22;
            this.lbUnitslnStock.Text = "Units ln Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(40, 281);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 21;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(40, 216);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(40, 151);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 19;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            this.lbCategoryId.AutoSize = true;
            this.lbCategoryId.Location = new System.Drawing.Point(40, 84);
            this.lbCategoryId.Name = "lbCategoryId";
            this.lbCategoryId.Size = new System.Drawing.Size(69, 20);
            this.lbCategoryId.TabIndex = 18;
            this.lbCategoryId.Text = "Category";
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 481);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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