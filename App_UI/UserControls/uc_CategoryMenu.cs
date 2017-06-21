using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_UI.UserControls
{
    public partial class uc_CategoryMenu : UserControl
    {
        public uc_CategoryMenu()
        {
            InitializeComponent();
        }

        private void uc_CategoryMenu_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
        }

        public void BindData()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Program.Categories)
            {
                CreateButton(item.CategoryID, item.CategoryName);
            }
        }

        public void CreateButton(int ID, string Name)
        {
            Button btn = new Button();
            btn.Name = "btn_" + ID;
            btn.Text = Name;
            btn.Tag = ID;
            btn.AutoSize = false;
            btn.Height = flowLayoutPanel1.Height - 7;
            btn.Width = 150;
            btn.Margin = new Padding(0);
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
            btn.FlatAppearance.MouseDownBackColor = Color.White;
            btn.Click += Btn_Click;
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;

            btn.BackColor = Color.FromArgb(255, 255, 255);
            if (Name == "All")
            {
                btn.ForeColor = Color.FromArgb(251, 51, 51);
            }
            else
            {
                btn.ForeColor = Color.Gray;
            }

            flowLayoutPanel1.Controls.Add(btn);
        }

        public void CreateButton(string name, string text)
        {
            Button btn = new Button();
            btn.Name = name;
            btn.Text = text;
            btn.AutoSize = false;
            btn.Height = flowLayoutPanel1.Height - 3;
            btn.Width = 100;
            btn.Margin = new Padding(0);
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI Semilight", 12, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
            btn.FlatAppearance.MouseDownBackColor = Color.White;
            btn.Click += Btn_Click;
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;
            flowLayoutPanel1.Controls.Add(btn);
            btn.BackColor = Color.FromArgb(255, 255, 255);
            if (text == "All")
            {
                btn.ForeColor = Color.FromArgb(251, 51, 51);
            }
            else
            {
                btn.ForeColor = Color.Gray;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Gray;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.FromArgb(251, 51, 51);
        }

        public event EventHandler EventCategoryClicked;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.FromArgb(251, 51, 51);

            EventCategoryClicked(btn.Tag, EventArgs.Empty);

        }
    }
}
