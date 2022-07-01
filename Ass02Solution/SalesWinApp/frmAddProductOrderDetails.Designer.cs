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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUndo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaveAddOrderDetails = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(359, 264);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(12, 359);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 30);
            this.btnUndo.TabIndex = 19;
            this.btnUndo.Text = "Remove";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveAddOrderDetails
            // 
            this.btnSaveAddOrderDetails.Location = new System.Drawing.Point(153, 359);
            this.btnSaveAddOrderDetails.Name = "btnSaveAddOrderDetails";
            this.btnSaveAddOrderDetails.Size = new System.Drawing.Size(75, 30);
            this.btnSaveAddOrderDetails.TabIndex = 17;
            this.btnSaveAddOrderDetails.Text = "Save";
            this.btnSaveAddOrderDetails.UseVisualStyleBackColor = true;
            this.btnSaveAddOrderDetails.Click += new System.EventHandler(this.btnSaveAddOrderDetails_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(73, 25);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(155, 23);
            this.cbProducts.TabIndex = 15;
            this.cbProducts.Click += new System.EventHandler(this.cbProducts_Click);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(234, 26);
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
            this.lbProduct.Location = new System.Drawing.Point(12, 28);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(49, 15);
            this.lbProduct.TabIndex = 12;
            this.lbProduct.Text = "Product";
            // 
            // frmAddProductOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveAddOrderDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.lbProduct);
            this.Name = "frmAddProductOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProductOrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaveAddOrderDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label lbProduct;
    }
}