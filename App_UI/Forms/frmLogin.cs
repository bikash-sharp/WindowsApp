using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_BAL;
using App_Wrapper;
using System.Web.Script.Serialization;

namespace App_UI.Forms
{
    public partial class frmLogin : CommonForm
    {

        public frmLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                    string URL = Program.BaseUrl;
                    string LoginUrl = URL + "/login?username=" + txtUserName.Text.Trim() + "&password=" + txtPassword.Text.Trim();

                    var GetLoginDetails = DataProviderWrapper.Instance.GetData(LoginUrl, Verbs.GET, "");
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    LoginCL result = serializer.Deserialize<LoginCL>(GetLoginDetails);

                    //if(txtUserName.Text == "Admin" && txtPassword.Text == "12345")
                    if (result.message == "success")
                    {
                        this.Hide();
                        Program.Token = result.data;
                        frmMain _main = new frmMain();
                        _main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed For User ?", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            //this.Hide();
            //frmForgotPassword forgotpswd = new frmForgotPassword();
            //forgotpswd.ShowDialog();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "tanent_admin_1";
            txtPassword.Text = "welcome2sw";
        }
    }
}
