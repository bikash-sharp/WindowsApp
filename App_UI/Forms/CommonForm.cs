using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_UI.Forms
{
    public class CommonForm : Form
    {
        public static bool IsClosed = false;
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (IsClosed)
            {
                Application.ExitThread();
            }

            //base.OnFormClosed(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Do you want to Exit Application ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msgResult == DialogResult.No)
            {
                e.Cancel = true;
                IsClosed = false;
            }
            else
            {
                IsClosed = true;
            }

            //base.OnFormClosing(e);
        }
    }
}
