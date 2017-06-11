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
            this.txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "" && this.txtPassword.TextLength > 0)
            {
                this.txtPassword.UseSystemPasswordChar = false;
                this.txtPassword.Text = "Password";
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword forgotpswd = new frmForgotPassword();
            forgotpswd.ShowDialog();
        }
    }
}
