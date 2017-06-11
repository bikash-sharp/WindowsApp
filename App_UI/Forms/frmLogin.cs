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
    public partial class frmLogin : Form
    {
        public static bool IsClosed = false;
        public frmLogin()
        {
            InitializeComponent();
            this.txtUserName.Text = "User Name";
            this.txtUserName.SelectionStart = 0;
            this.txtPassword.Text = "Password";
            this.txtPassword.SelectionStart = 0;

            this.pictureBox1.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Do you want to Exit Application ?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (msgResult == DialogResult.No)
            {
                e.Cancel = true;
                IsClosed = false;
            }
            else
            {
                IsClosed = true;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsClosed)
            {
                Application.ExitThread();
            }
        }
    }
}
