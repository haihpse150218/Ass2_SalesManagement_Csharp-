using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using BusinessObject;
using DataAccess.Models;


namespace SalesWinApp
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MemberObject member = new MemberObject
            {
                Email = txtEmailAdd.Text,
                Password = txtPasswordAdd.Text,
                CompanyName =txtCompanyNameAdd.Text,
                City = txtCityAdd.Text,
                Country = txtCountryAdd.Text
            };
            FStore2Context db = new FStore2Context();

            var config = new MapperConfiguration(cfg =>
               cfg.CreateMap<MemberObject, Member>()
           );
            //Using AutoMapper
            var mapper = new Mapper(config);
            Member mem = mapper.Map<Member>(member);
            db.Members.Add(mem);
            db.SaveChanges();
        }

        private void btnCloseAddMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmailAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailAdd.Text))
            {
                e.Cancel = true;
                txtEmailAdd.Focus();
                EmailValidate.SetError(txtEmailAdd, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                EmailValidate.SetError(txtEmailAdd, "");
            }
        }

        private void txtEmailAdd_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (txtEmailAdd.Text.Trim() != string.Empty)

            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmailAdd.Text, pattern))
                {
                    EmailFormat.Clear();
                    btnCreate.Enabled = true;
                }
                else
                {
                    EmailFormat.SetError(this.txtEmailAdd, "E-mail address format is not correct.");
                    btnCreate.Enabled = false;
                }


            }
        }

        private void txtPasswordAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordAdd.Text))
            {
                e.Cancel = true;
                txtPasswordAdd.Focus();
                PasswordValidate.SetError(txtPasswordAdd, "Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                PasswordValidate.SetError(txtPasswordAdd, "");
            }
        }
    }
}
