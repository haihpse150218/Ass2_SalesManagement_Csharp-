namespace SalesWinApp
{
    partial class frmAddMember
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
            this.btnCloseAddMember = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCountryAdd = new System.Windows.Forms.TextBox();
            this.txtCityAdd = new System.Windows.Forms.TextBox();
            this.txtCompanyNameAdd = new System.Windows.Forms.TextBox();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.EmailValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailFormat = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseAddMember);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtCountryAdd);
            this.panel1.Controls.Add(this.txtCityAdd);
            this.panel1.Controls.Add(this.txtCompanyNameAdd);
            this.panel1.Controls.Add(this.txtPasswordAdd);
            this.panel1.Controls.Add(this.txtEmailAdd);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseAddMember
            // 
            this.btnCloseAddMember.Location = new System.Drawing.Point(326, 373);
            this.btnCloseAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseAddMember.Name = "btnCloseAddMember";
            this.btnCloseAddMember.Size = new System.Drawing.Size(86, 47);
            this.btnCloseAddMember.TabIndex = 11;
            this.btnCloseAddMember.Text = "Close";
            this.btnCloseAddMember.UseVisualStyleBackColor = true;
            this.btnCloseAddMember.Click += new System.EventHandler(this.btnCloseAddMember_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(147, 373);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 47);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(147, 303);
            this.txtCountryAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(263, 27);
            this.txtCountryAdd.TabIndex = 9;
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(147, 237);
            this.txtCityAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(263, 27);
            this.txtCityAdd.TabIndex = 8;
            // 
            // txtCompanyNameAdd
            // 
            this.txtCompanyNameAdd.Location = new System.Drawing.Point(147, 172);
            this.txtCompanyNameAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyNameAdd.Name = "txtCompanyNameAdd";
            this.txtCompanyNameAdd.Size = new System.Drawing.Size(263, 27);
            this.txtCompanyNameAdd.TabIndex = 7;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(147, 107);
            this.txtPasswordAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(263, 27);
            this.txtPasswordAdd.TabIndex = 6;
            this.txtPasswordAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordAdd_Validating);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(147, 40);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(263, 27);
            this.txtEmailAdd.TabIndex = 5;
            this.txtEmailAdd.Leave += new System.EventHandler(this.txtEmailAdd_Leave);
            this.txtEmailAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailAdd_Validating);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(26, 308);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(26, 243);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(26, 177);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(26, 112);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(26, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // EmailValidate
            // 
            this.EmailValidate.ContainerControl = this;
            // 
            // PasswordValidate
            // 
            this.PasswordValidate.ContainerControl = this;
            // 
            // EmailFormat
            // 
            this.EmailFormat.ContainerControl = this;
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 481);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailFormat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCountryAdd;
        private System.Windows.Forms.TextBox txtCityAdd;
        private System.Windows.Forms.TextBox txtCompanyNameAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnCloseAddMember;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ErrorProvider EmailValidate;
        private System.Windows.Forms.ErrorProvider PasswordValidate;
        private System.Windows.Forms.ErrorProvider EmailFormat;
    }
}