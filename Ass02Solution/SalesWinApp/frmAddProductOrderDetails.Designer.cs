namespace SalesWinApp
{
    partial class frmAddProductOrderDetails
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
            this.components = new System.ComponentModel.Container();
            this.orderDetailObjecBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productObjectBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.productObjectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailObjecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSaveAddOrderDetails = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.productObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbProduct = new System.Windows.Forms.Label();
            this.orderObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productObjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productObjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailObjecBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAddProductOrderDetails = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailObjecBindingSource2
            // 
            this.orderDetailObjecBindingSource2.DataSource = typeof(BusinessObject.OrderDetailObjec);
            // 
            // productObjectBindingSource4
            // 
            this.productObjectBindingSource4.DataSource = typeof(BusinessObject.ProductObject);
            // 
            // productObjectBindingSource3
            // 
            this.productObjectBindingSource3.DataSource = typeof(BusinessObject.ProductObject);
            // 
            // orderDetailObjecBindingSource
            // 
            this.orderDetailObjecBindingSource.DataSource = typeof(BusinessObject.OrderDetailObjec);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(382, 19);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 53);
            this.btnUndo.TabIndex = 19;
            this.btnUndo.Text = "Remove";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSaveAddOrderDetails
            // 
            this.btnSaveAddOrderDetails.Location = new System.Drawing.Point(618, 20);
            this.btnSaveAddOrderDetails.Name = "btnSaveAddOrderDetails";
            this.btnSaveAddOrderDetails.Size = new System.Drawing.Size(75, 51);
            this.btnSaveAddOrderDetails.TabIndex = 17;
            this.btnSaveAddOrderDetails.Text = "Save";
            this.btnSaveAddOrderDetails.UseVisualStyleBackColor = true;
            this.btnSaveAddOrderDetails.Click += new System.EventHandler(this.btnSaveAddOrderDetails_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.DataSource = this.productObjectBindingSource;
            this.cbProducts.DisplayMember = "ProductName";
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(78, 31);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(155, 23);
            this.cbProducts.TabIndex = 15;
            this.cbProducts.SelectionChangeCommitted += new System.EventHandler(this.cbProducts_SelectionChangeCommitted);
            this.cbProducts.Click += new System.EventHandler(this.cbProducts_Click);
            // 
            // productObjectBindingSource
            // 
            this.productObjectBindingSource.DataSource = typeof(BusinessObject.ProductObject);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(239, 32);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(56, 23);
            this.nmQuantity.TabIndex = 13;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(17, 34);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(49, 15);
            this.lbProduct.TabIndex = 12;
            this.lbProduct.Text = "Product";
            // 
            // orderObjectBindingSource
            // 
            this.orderObjectBindingSource.DataSource = typeof(BusinessObject.OrderObject);
            // 
            // productObjectBindingSource1
            // 
            this.productObjectBindingSource1.DataSource = typeof(BusinessObject.ProductObject);
            // 
            // productObjectBindingSource2
            // 
            this.productObjectBindingSource2.DataSource = typeof(BusinessObject.ProductObject);
            // 
            // orderDetailObjecBindingSource1
            // 
            this.orderDetailObjecBindingSource1.DataSource = typeof(BusinessObject.OrderDetailObjec);
            // 
            // dgvAddProductOrderDetails
            // 
            this.dgvAddProductOrderDetails.AutoGenerateColumns = false;
            this.dgvAddProductOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddProductOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProductOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvAddProductOrderDetails.DataSource = this.orderDetailObjecBindingSource2;
            this.dgvAddProductOrderDetails.Location = new System.Drawing.Point(12, 89);
            this.dgvAddProductOrderDetails.Name = "dgvAddProductOrderDetails";
            this.dgvAddProductOrderDetails.RowTemplate.Height = 25;
            this.dgvAddProductOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddProductOrderDetails.Size = new System.Drawing.Size(681, 264);
            this.dgvAddProductOrderDetails.TabIndex = 20;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmAddProductOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 374);
            this.Controls.Add(this.dgvAddProductOrderDetails);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSaveAddOrderDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.lbProduct);
            this.Name = "frmAddProductOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProductOrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productObjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailObjecBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSaveAddOrderDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.BindingSource productObjectBindingSource;
        private System.Windows.Forms.BindingSource orderObjectBindingSource;
        private System.Windows.Forms.BindingSource productObjectBindingSource1;
        private System.Windows.Forms.BindingSource orderDetailObjecBindingSource;
        private System.Windows.Forms.BindingSource productObjectBindingSource3;
        private System.Windows.Forms.BindingSource productObjectBindingSource2;
        private System.Windows.Forms.BindingSource orderDetailObjecBindingSource1;
        private System.Windows.Forms.BindingSource productObjectBindingSource4;
        private System.Windows.Forms.BindingSource orderDetailObjecBindingSource2;
        private System.Windows.Forms.DataGridView dgvAddProductOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}