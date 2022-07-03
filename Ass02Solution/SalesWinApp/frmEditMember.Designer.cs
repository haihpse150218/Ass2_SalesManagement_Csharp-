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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtCityEdit = new System.Windows.Forms.TextBox();
            this.txtCountryEdit = new System.Windows.Forms.TextBox();
            this.txtPasswordEdit = new System.Windows.Forms.TextBox();
            this.txtCompanyNameEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtIdEdit = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.EmailFormat = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValidate)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 475);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Location = new System.Drawing.Point(314, 407);
            this.btnCloseEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(86, 45);
            this.btnCloseEdit.TabIndex = 18;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.UseVisualStyleBackColor = true;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Location = new System.Drawing.Point(166, 407);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 45);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCityEdit
            // 
            this.txtCityEdit.Location = new System.Drawing.Point(166, 279);
            this.txtCityEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityEdit.Name = "txtCityEdit";
            this.txtCityEdit.Size = new System.Drawing.Size(234, 27);
            this.txtCityEdit.TabIndex = 16;
            // 
            // txtCountryEdit
            // 
            this.txtCountryEdit.Location = new System.Drawing.Point(166, 340);
            this.txtCountryEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountryEdit.Name = "txtCountryEdit";
            this.txtCountryEdit.Size = new System.Drawing.Size(234, 27);
            this.txtCountryEdit.TabIndex = 15;
            // 
            // txtPasswordEdit
            // 
            this.txtPasswordEdit.Location = new System.Drawing.Point(166, 156);
            this.txtPasswordEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordEdit.Name = "txtPasswordEdit";
            this.txtPasswordEdit.Size = new System.Drawing.Size(234, 27);
            this.txtPasswordEdit.TabIndex = 14;
            this.txtPasswordEdit.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordEdit_Validating);
            // 
            // txtCompanyNameEdit
            // 
            this.txtCompanyNameEdit.Location = new System.Drawing.Point(166, 217);
            this.txtCompanyNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyNameEdit.Name = "txtCompanyNameEdit";
            this.txtCompanyNameEdit.Size = new System.Drawing.Size(234, 27);
            this.txtCompanyNameEdit.TabIndex = 13;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(166, 95);
            this.txtEmailEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(234, 27);
            this.txtEmailEdit.TabIndex = 12;
            this.txtEmailEdit.Leave += new System.EventHandler(this.txtEmailEdit_Leave);
            this.txtEmailEdit.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailEdit_Validating);
            // 
            // txtIdEdit
            // 
            this.txtIdEdit.Location = new System.Drawing.Point(166, 33);
            this.txtIdEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdEdit.Name = "txtIdEdit";
            this.txtIdEdit.ReadOnly = true;
            this.txtIdEdit.Size = new System.Drawing.Size(234, 27);
            this.txtIdEdit.TabIndex = 11;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(35, 37);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 20);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "ID";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(35, 351);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 9;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(35, 285);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 8;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(35, 220);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbCompanyName.TabIndex = 7;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(35, 155);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(35, 88);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // EmailFormat
            // 
            this.EmailFormat.ContainerControl = this;
            // 
            // EmailValidate
            // 
            this.EmailValidate.ContainerControl = this;
            // 
            // PasswordValidate
            // 
            this.PasswordValidate.ContainerControl = this;
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 507);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEditMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValidate)).EndInit();
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
        private System.Windows.Forms.ErrorProvider EmailFormat;
        private System.Windows.Forms.ErrorProvider EmailValidate;
        private System.Windows.Forms.ErrorProvider PasswordValidate;
    }
}