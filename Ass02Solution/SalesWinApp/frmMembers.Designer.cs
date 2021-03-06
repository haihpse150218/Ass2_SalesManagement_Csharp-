namespace SalesWinApp
{
    partial class frmMembers
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvManagerMembers = new System.Windows.Forms.DataGridView();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvManagerMembers);
            this.panel1.Controls.Add(this.btnRemoveMember);
            this.panel1.Controls.Add(this.btnEditMember);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 385);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 64);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manager Members";
            // 
            // dgvManagerMembers
            // 
            this.dgvManagerMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvManagerMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerMembers.Location = new System.Drawing.Point(12, 83);
            this.dgvManagerMembers.Name = "dgvManagerMembers";
            this.dgvManagerMembers.RowTemplate.Height = 25;
            this.dgvManagerMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagerMembers.Size = new System.Drawing.Size(476, 291);
            this.dgvManagerMembers.TabIndex = 9;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(536, 284);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(118, 49);
            this.btnRemoveMember.TabIndex = 8;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(536, 193);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(118, 49);
            this.btnEditMember.TabIndex = 7;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click_1);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(536, 102);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(118, 49);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = "Add New Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click_1);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 388);
            this.Controls.Add(this.panel1);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Members";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.DataGridView dgvManagerMembers;
        private System.Windows.Forms.Label label2;
    }
}