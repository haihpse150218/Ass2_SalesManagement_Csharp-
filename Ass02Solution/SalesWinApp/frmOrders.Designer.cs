namespace SalesWinApp
{
    partial class frmOrders
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
            this.tabOrders = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSortSalesDescending = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnLoadAllOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dtToDateOrder = new System.Windows.Forms.DateTimePicker();
            this.lbToDate = new System.Windows.Forms.Label();
            this.dtFromDateOrder = new System.Windows.Forms.DateTimePicker();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.btLoadOrder = new System.Windows.Forms.Button();
            this.OrderDetails = new System.Windows.Forms.TabPage();
            this.txtFeightDetails = new System.Windows.Forms.TextBox();
            this.dtOrderDateDetails = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMemberNameDetails = new System.Windows.Forms.TextBox();
            this.txtMemberIdDetails = new System.Windows.Forms.TextBox();
            this.txtOderIdDetails = new System.Windows.Forms.TextBox();
            this.btnAddOrderDetails = new System.Windows.Forms.Button();
            this.btnCreateOderDetails = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TabPage();
            this.tabOrders.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.Orders);
            this.tabOrders.Controls.Add(this.OrderDetails);
            this.tabOrders.Controls.Add(this.Report);
            this.tabOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrders.Location = new System.Drawing.Point(0, 0);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.SelectedIndex = 0;
            this.tabOrders.Size = new System.Drawing.Size(678, 388);
            this.tabOrders.TabIndex = 1;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.btnCreateOrder);
            this.Orders.Controls.Add(this.btnEdit);
            this.Orders.Controls.Add(this.btnSortSalesDescending);
            this.Orders.Controls.Add(this.btnCreateReport);
            this.Orders.Controls.Add(this.btnViewDetails);
            this.Orders.Controls.Add(this.btnLoadAllOrder);
            this.Orders.Controls.Add(this.dgvOrder);
            this.Orders.Controls.Add(this.dtToDateOrder);
            this.Orders.Controls.Add(this.lbToDate);
            this.Orders.Controls.Add(this.dtFromDateOrder);
            this.Orders.Controls.Add(this.lbFromDate);
            this.Orders.Controls.Add(this.btLoadOrder);
            this.Orders.Location = new System.Drawing.Point(4, 24);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(670, 360);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(577, 115);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(83, 43);
            this.btnCreateOrder.TabIndex = 12;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(577, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 43);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Order";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSortSalesDescending
            // 
            this.btnSortSalesDescending.Location = new System.Drawing.Point(577, 243);
            this.btnSortSalesDescending.Name = "btnSortSalesDescending";
            this.btnSortSalesDescending.Size = new System.Drawing.Size(83, 43);
            this.btnSortSalesDescending.TabIndex = 10;
            this.btnSortSalesDescending.Text = "Sort Sales In Descending Order";
            this.btnSortSalesDescending.UseVisualStyleBackColor = true;
            this.btnSortSalesDescending.Click += new System.EventHandler(this.btnSortSalesDescending_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(577, 307);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(83, 43);
            this.btnCreateReport.TabIndex = 9;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(579, 51);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(83, 43);
            this.btnViewDetails.TabIndex = 8;
            this.btnViewDetails.Text = "View Detail";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnLoadAllOrder
            // 
            this.btnLoadAllOrder.Location = new System.Drawing.Point(496, 8);
            this.btnLoadAllOrder.Name = "btnLoadAllOrder";
            this.btnLoadAllOrder.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAllOrder.TabIndex = 7;
            this.btnLoadAllOrder.Text = "Load All";
            this.btnLoadAllOrder.UseVisualStyleBackColor = true;
            this.btnLoadAllOrder.Click += new System.EventHandler(this.btnLoadAllOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(8, 51);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(563, 301);
            this.dgvOrder.TabIndex = 5;
            // 
            // dtToDateOrder
            // 
            this.dtToDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDateOrder.Location = new System.Drawing.Point(278, 8);
            this.dtToDateOrder.Name = "dtToDateOrder";
            this.dtToDateOrder.Size = new System.Drawing.Size(98, 23);
            this.dtToDateOrder.TabIndex = 4;
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(213, 15);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(46, 15);
            this.lbToDate.TabIndex = 3;
            this.lbToDate.Text = "To Date";
            // 
            // dtFromDateOrder
            // 
            this.dtFromDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDateOrder.Location = new System.Drawing.Point(92, 8);
            this.dtFromDateOrder.Name = "dtFromDateOrder";
            this.dtFromDateOrder.Size = new System.Drawing.Size(96, 23);
            this.dtFromDateOrder.TabIndex = 2;
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(11, 15);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(62, 15);
            this.lbFromDate.TabIndex = 1;
            this.lbFromDate.Text = "From Date";
            // 
            // btLoadOrder
            // 
            this.btLoadOrder.Location = new System.Drawing.Point(398, 8);
            this.btLoadOrder.Name = "btLoadOrder";
            this.btLoadOrder.Size = new System.Drawing.Size(75, 23);
            this.btLoadOrder.TabIndex = 0;
            this.btLoadOrder.Text = "Load";
            this.btLoadOrder.UseVisualStyleBackColor = true;
            this.btLoadOrder.Click += new System.EventHandler(this.btLoadOrder_Click);
            // 
            // OrderDetails
            // 
            this.OrderDetails.Controls.Add(this.txtFeightDetails);
            this.OrderDetails.Controls.Add(this.dtOrderDateDetails);
            this.OrderDetails.Controls.Add(this.dateTimePicker2);
            this.OrderDetails.Controls.Add(this.dateTimePicker1);
            this.OrderDetails.Controls.Add(this.txtMemberNameDetails);
            this.OrderDetails.Controls.Add(this.txtMemberIdDetails);
            this.OrderDetails.Controls.Add(this.txtOderIdDetails);
            this.OrderDetails.Controls.Add(this.btnAddOrderDetails);
            this.OrderDetails.Controls.Add(this.btnCreateOderDetails);
            this.OrderDetails.Controls.Add(this.dgvOrderDetails);
            this.OrderDetails.Controls.Add(this.lbFreight);
            this.OrderDetails.Controls.Add(this.lbShippedDate);
            this.OrderDetails.Controls.Add(this.label1);
            this.OrderDetails.Controls.Add(this.lbRequiredDate);
            this.OrderDetails.Controls.Add(this.lbOrderDate);
            this.OrderDetails.Controls.Add(this.lbCustomerId);
            this.OrderDetails.Controls.Add(this.lbOrderId);
            this.OrderDetails.Location = new System.Drawing.Point(4, 24);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.OrderDetails.Size = new System.Drawing.Size(670, 360);
            this.OrderDetails.TabIndex = 1;
            this.OrderDetails.Text = "Order Details";
            this.OrderDetails.UseVisualStyleBackColor = true;
            // 
            // txtFeightDetails
            // 
            this.txtFeightDetails.Location = new System.Drawing.Point(542, 90);
            this.txtFeightDetails.Name = "txtFeightDetails";
            this.txtFeightDetails.ReadOnly = true;
            this.txtFeightDetails.Size = new System.Drawing.Size(115, 23);
            this.txtFeightDetails.TabIndex = 17;
            // 
            // dtOrderDateDetails
            // 
            this.dtOrderDateDetails.Enabled = false;
            this.dtOrderDateDetails.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDateDetails.Location = new System.Drawing.Point(354, 13);
            this.dtOrderDateDetails.Name = "dtOrderDateDetails";
            this.dtOrderDateDetails.Size = new System.Drawing.Size(115, 23);
            this.dtOrderDateDetails.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(354, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtMemberNameDetails
            // 
            this.txtMemberNameDetails.Location = new System.Drawing.Point(354, 49);
            this.txtMemberNameDetails.Name = "txtMemberNameDetails";
            this.txtMemberNameDetails.ReadOnly = true;
            this.txtMemberNameDetails.Size = new System.Drawing.Size(115, 23);
            this.txtMemberNameDetails.TabIndex = 13;
            // 
            // txtMemberIdDetails
            // 
            this.txtMemberIdDetails.Location = new System.Drawing.Point(104, 51);
            this.txtMemberIdDetails.Name = "txtMemberIdDetails";
            this.txtMemberIdDetails.ReadOnly = true;
            this.txtMemberIdDetails.Size = new System.Drawing.Size(126, 23);
            this.txtMemberIdDetails.TabIndex = 12;
            // 
            // txtOderIdDetails
            // 
            this.txtOderIdDetails.Location = new System.Drawing.Point(104, 11);
            this.txtOderIdDetails.Name = "txtOderIdDetails";
            this.txtOderIdDetails.ReadOnly = true;
            this.txtOderIdDetails.Size = new System.Drawing.Size(126, 23);
            this.txtOderIdDetails.TabIndex = 11;
            // 
            // btnAddOrderDetails
            // 
            this.btnAddOrderDetails.Location = new System.Drawing.Point(592, 155);
            this.btnAddOrderDetails.Name = "btnAddOrderDetails";
            this.btnAddOrderDetails.Size = new System.Drawing.Size(75, 43);
            this.btnAddOrderDetails.TabIndex = 10;
            this.btnAddOrderDetails.Text = "Add Product";
            this.btnAddOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btnCreateOderDetails
            // 
            this.btnCreateOderDetails.Location = new System.Drawing.Point(592, 216);
            this.btnCreateOderDetails.Name = "btnCreateOderDetails";
            this.btnCreateOderDetails.Size = new System.Drawing.Size(75, 40);
            this.btnCreateOderDetails.TabIndex = 9;
            this.btnCreateOderDetails.Text = "Edit Order Details";
            this.btnCreateOderDetails.UseVisualStyleBackColor = true;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToOrderColumns = true;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(8, 155);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowTemplate.Height = 25;
            this.dgvOrderDetails.Size = new System.Drawing.Size(578, 197);
            this.dgvOrderDetails.TabIndex = 8;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(482, 97);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 7;
            this.lbFreight.Text = "Freight";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(252, 97);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lbShippedDate.TabIndex = 6;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member Name";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(7, 97);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 4;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(252, 22);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(8, 58);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(66, 15);
            this.lbCustomerId.TabIndex = 2;
            this.lbCustomerId.Text = "Member ID";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(8, 22);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(51, 15);
            this.lbOrderId.TabIndex = 1;
            this.lbOrderId.Text = "Order ID";
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 24);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(670, 360);
            this.Report.TabIndex = 2;
            this.Report.Text = "Report Statistics Sales";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 388);
            this.Controls.Add(this.tabOrders);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager Orders";
            this.tabOrders.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.OrderDetails.ResumeLayout(false);
            this.OrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrders;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSortSalesDescending;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnLoadAllOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DateTimePicker dtToDateOrder;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.DateTimePicker dtFromDateOrder;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.Button btLoadOrder;
        private System.Windows.Forms.TabPage OrderDetails;
        private System.Windows.Forms.TextBox txtFeightDetails;
        private System.Windows.Forms.DateTimePicker dtOrderDateDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMemberNameDetails;
        private System.Windows.Forms.TextBox txtMemberIdDetails;
        private System.Windows.Forms.TextBox txtOderIdDetails;
        private System.Windows.Forms.Button btnAddOrderDetails;
        private System.Windows.Forms.Button btnCreateOderDetails;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.TabPage Report;
    }
}