namespace SalesWinApp
{
    partial class frmEditMember
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
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtIdEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtCompanyNameEdit = new System.Windows.Forms.TextBox();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.txtCountryEdit = new System.Windows.Forms.TextBox();
            this.txtCityEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseEdit);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtCityEdit);
            this.panel1.Controls.Add(this.txtCountryEdit);
            this.panel1.Controls.Add(this.txtPasswordEdit);
            this.panel1.Controls.Add(this.txtCompanyNameEdit);
            this.panel1.Controls.Add(this.txtEmailEdit);
            this.panel1.Controls.Add(this.txtIdEdit);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 356);
            this.panel1.TabIndex = 0;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(31, 263);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 9;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(31, 214);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 8;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(31, 165);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lbCompanyName.TabIndex = 7;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(31, 116);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(31, 66);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(31, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 15);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "ID";
            // 
            // txtIdEdit
            // 
            this.txtIdEdit.Location = new System.Drawing.Point(145, 25);
            this.txtIdEdit.Name = "txtIdEdit";
            this.txtIdEdit.ReadOnly = true;
            this.txtIdEdit.Size = new System.Drawing.Size(205, 23);
            this.txtIdEdit.TabIndex = 11;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(145, 71);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(205, 23);
            this.txtEmailEdit.TabIndex = 12;
            // 
            // txtCompanyNameEdit
            // 
            this.txtCompanyNameEdit.Location = new System.Drawing.Point(145, 163);
            this.txtCompanyNameEdit.Name = "txtCompanyNameEdit";
            this.txtCompanyNameEdit.Size = new System.Drawing.Size(205, 23);
            this.txtCompanyNameEdit.TabIndex = 13;
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(145, 117);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(205, 23);
            this.txtPasswordEdit.TabIndex = 14;
            // 
            // txtCountryEdit
            // 
            this.txtCountryEdit.Location = new System.Drawing.Point(145, 255);
            this.txtCountryEdit.Name = "txtCountryEdit";
            this.txtCountryEdit.Size = new System.Drawing.Size(205, 23);
            this.txtCountryEdit.TabIndex = 15;
            // 
            // txtCityEdit
            // 
            this.txtCityEdit.Location = new System.Drawing.Point(145, 209);
            this.txtCityEdit.Name = "txtCityEdit";
            this.txtCityEdit.Size = new System.Drawing.Size(205, 23);
            this.txtCityEdit.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(145, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Location = new System.Drawing.Point(275, 305);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(75, 34);
            this.btnCloseEdit.TabIndex = 18;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.UseVisualStyleBackColor = true;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 380);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCityEdit;
        private System.Windows.Forms.TextBox txtCountryEdit;
        private System.Windows.Forms.TextBox txtPasswordEdit;
        private System.Windows.Forms.TextBox txtCompanyNameEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtIdEdit;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
    }
}