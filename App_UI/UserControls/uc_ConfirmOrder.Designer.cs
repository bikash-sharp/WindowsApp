﻿namespace App_UI.UserControls
{
    partial class uc_ConfirmOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flyLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flyLayout
            // 
            this.flyLayout.BackColor = System.Drawing.Color.White;
            this.flyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyLayout.Location = new System.Drawing.Point(0, 0);
            this.flyLayout.Name = "flyLayout";
            this.flyLayout.Size = new System.Drawing.Size(523, 335);
            this.flyLayout.TabIndex = 0;
            // 
            // uc_ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_ConfirmOrder";
            this.Size = new System.Drawing.Size(523, 335);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flyLayout;
    }
}
