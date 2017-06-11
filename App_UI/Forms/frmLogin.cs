using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_UI.Forms
{
    public partial class frmLogin : CommonForm
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //btnLogin.TabStop = false;
            //this.btnLogin.FlatStyle = FlatStyle.Flat;
            //this.btnLogin.FlatAppearance.BorderColor = Color.White;
            //this.btnLogin.FlatAppearance.BorderSize = 0;

            if (String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                this.rectangleShape2.BorderColor = Color.FromArgb(251, 51, 51);
                this.txtUserName.Focus();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                this.rectangleShape3.BorderColor = Color.FromArgb(251, 51, 51);
                this.txtPassword.Focus();
            }
            else
            {
                this.rectangleShape2.BorderColor = Color.FromArgb(225, 225, 225);
                this.rectangleShape3.BorderColor = Color.FromArgb(225, 225, 225);
                try
                {
                    this.Hide();
                    frmMain _main = new frmMain();
                    _main.ShowDialog();
                }
                catch (Exception ex)
                {
                    var err = ex.Message;

                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "" && this.txtPassword.TextLength > 0)
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Password";
                this.rectangleShape3.BorderColor = Color.FromArgb(251, 51, 51);
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
                this.rectangleShape3.BorderColor = Color.FromArgb(225, 225, 225);
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword forgotpswd = new frmForgotPassword();
            forgotpswd.ShowDialog();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == "" && this.txtUserName.TextLength > 0)
            {
                this.txtUserName.Text = "User Name";
                this.rectangleShape2.BorderColor = Color.FromArgb(251, 51, 51);
            }
            else
            {
                this.rectangleShape2.BorderColor = Color.FromArgb(225, 225, 225);
            }
        }
    }
}
