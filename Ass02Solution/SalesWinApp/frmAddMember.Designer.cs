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
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 336);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseAddMember
            // 
            this.btnCloseAddMember.Location = new System.Drawing.Point(285, 280);
            this.btnCloseAddMember.Name = "btnCloseAddMember";
            this.btnCloseAddMember.Size = new System.Drawing.Size(75, 35);
            this.btnCloseAddMember.TabIndex = 11;
            this.btnCloseAddMember.Text = "Close";
            this.btnCloseAddMember.UseVisualStyleBackColor = true;
            this.btnCloseAddMember.Click += new System.EventHandler(this.btnCloseAddMember_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(129, 280);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 35);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCountryAdd
            // 
            this.txtCountryAdd.Location = new System.Drawing.Point(129, 227);
            this.txtCountryAdd.Name = "txtCountryAdd";
            this.txtCountryAdd.Size = new System.Drawing.Size(231, 23);
            this.txtCountryAdd.TabIndex = 9;
            // 
            // txtCityAdd
            // 
            this.txtCityAdd.Location = new System.Drawing.Point(129, 178);
            this.txtCityAdd.Name = "txtCityAdd";
            this.txtCityAdd.Size = new System.Drawing.Size(231, 23);
            this.txtCityAdd.TabIndex = 8;
            // 
            // txtCompanyNameAdd
            // 
            this.txtCompanyNameAdd.Location = new System.Drawing.Point(129, 129);
            this.txtCompanyNameAdd.Name = "txtCompanyNameAdd";
            this.txtCompanyNameAdd.Size = new System.Drawing.Size(231, 23);
            this.txtCompanyNameAdd.TabIndex = 7;
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(129, 80);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(231, 23);
            this.txtPasswordAdd.TabIndex = 6;
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(129, 30);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(231, 23);
            this.txtEmailAdd.TabIndex = 5;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(23, 231);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(23, 182);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(23, 133);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(94, 15);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(23, 84);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 34);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 361);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}