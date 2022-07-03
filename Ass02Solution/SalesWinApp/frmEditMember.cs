using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using BusinessObject;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace SalesWinApp
{
    public partial class frmEditMember : Form
    {
        MemberObject member = new MemberObject();
        public frmEditMember()
        {
            InitializeComponent();
        }
        public frmEditMember(BusinessObject.MemberObject mem)
        {
            MemberObject? memberObject = mem;
            InitializeComponent();
            if (memberObject != null)
            {
                txtIdEdit.Text = memberObject.MemberId.ToString();
                txtEmailEdit.Text = memberObject.Email;
                txtPasswordEdit.Text = memberObject.Password;
                txtCompanyNameEdit.Text = memberObject.CompanyName;
                txtCityEdit.Text = memberObject.City;
                txtCountryEdit.Text = memberObject.Country;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FStore2Context db = new FStore2Context();
            
                member.MemberId = Convert.ToInt32(txtIdEdit.Text);
                member.Email = txtEmailEdit.Text.Trim();
                member.Password = txtPasswordEdit.Text.Trim();
                member.CompanyName = txtCompanyNameEdit.Text.Trim();
                member.City = txtCityEdit.Text.Trim();
                member.Country = txtCountryEdit.Text.Trim();
                var result = db.Members.Where(m => m.MemberId == member.MemberId).FirstOrDefault();
                result.Email = txtEmailEdit.Text.Trim();
                result.Password = txtPasswordEdit.Text.Trim();
                result.CompanyName = txtCompanyNameEdit.Text.Trim();
                result.City = txtCityEdit.Text.Trim();
                result.Country = txtCountryEdit.Text.Trim();
                db.SaveChanges();
            
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtEmailEdit_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (txtEmailEdit.Text.Trim() != string.Empty)

            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmailEdit.Text, pattern))
                {
                    EmailFormat.Clear();
                    btnEdit.Enabled = true;
                }
                else
                {
                    EmailFormat.SetError(this.txtEmailEdit, "E-mail address format is not correct.");
                    btnEdit.Enabled = false;
                }


            }
        }

        private void txtEmailEdit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailEdit.Text))
            {
                e.Cancel = true;
                txtEmailEdit.Focus();
                EmailValidate.SetError(txtEmailEdit, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                EmailValidate.SetError(txtEmailEdit, "");
            }
        }

        private void txtPasswordEdit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordEdit.Text))
            {
                e.Cancel = true;
                txtPasswordEdit.Focus();
                PasswordValidate.SetError(txtPasswordEdit, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                PasswordValidate.SetError(txtPasswordEdit, "");
            }
        }
    }
}
