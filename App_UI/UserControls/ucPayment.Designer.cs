﻿namespace App_UI.UserControls
{
    partial class ucPayment
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
            this.tblBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.btnExactAmount = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblRem = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblCardMsg = new System.Windows.Forms.Label();
            this.tblBase.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBase
            // 
            this.tblBase.ColumnCount = 4;
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblBase.Controls.Add(this.lblTotal, 0, 0);
            this.tblBase.Controls.Add(this.btnPay, 0, 4);
            this.tblBase.Controls.Add(this.btnCancel, 2, 4);
            this.tblBase.Controls.Add(this.btnCash, 0, 1);
            this.tblBase.Controls.Add(this.btnCard, 0, 2);
            this.tblBase.Controls.Add(this.pnlBase, 1, 1);
            this.tblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBase.Location = new System.Drawing.Point(0, 0);
            this.tblBase.Name = "tblBase";
            this.tblBase.RowCount = 5;
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblBase.Size = new System.Drawing.Size(504, 419);
            this.tblBase.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Silver;
            this.tblBase.SetColumnSpan(this.lblTotal, 4);
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(504, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.tblBase.SetColumnSpan(this.btnPay, 2);
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(1, 348);
            this.btnPay.Margin = new System.Windows.Forms.Padding(1);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(250, 70);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tblBase.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(253, 348);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 70);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCash
            // 
            this.btnCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCash.Location = new System.Drawing.Point(1, 50);
            this.btnCash.Margin = new System.Windows.Forms.Padding(1);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(134, 49);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCard.Location = new System.Drawing.Point(1, 101);
            this.btnCard.Margin = new System.Windows.Forms.Padding(1);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(134, 49);
            this.btnCard.TabIndex = 4;
            this.btnCard.Text = "CARD";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // pnlBase
            // 
            this.tblBase.SetColumnSpan(this.pnlBase, 3);
            this.pnlBase.Controls.Add(this.pnlCash);
            this.pnlBase.Controls.Add(this.pnlCard);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(136, 49);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBase.Name = "pnlBase";
            this.tblBase.SetRowSpan(this.pnlBase, 3);
            this.pnlBase.Size = new System.Drawing.Size(368, 298);
            this.pnlBase.TabIndex = 5;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.btnExactAmount);
            this.pnlCash.Controls.Add(this.txtAmount);
            this.pnlCash.Controls.Add(this.lblRem);
            this.pnlCash.Controls.Add(this.lblAmount);
            this.pnlCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCash.Location = new System.Drawing.Point(0, 0);
            this.pnlCash.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(368, 298);
            this.pnlCash.TabIndex = 1;
            // 
            // btnExactAmount
            // 
            this.btnExactAmount.Location = new System.Drawing.Point(142, 87);
            this.btnExactAmount.Name = "btnExactAmount";
            this.btnExactAmount.Size = new System.Drawing.Size(163, 31);
            this.btnExactAmount.TabIndex = 3;
            this.btnExactAmount.Text = "Exact Amount";
            this.btnExactAmount.UseVisualStyleBackColor = true;
            this.btnExactAmount.Click += new System.EventHandler(this.btnExactAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(142, 37);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(163, 29);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblRem
            // 
            this.lblRem.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(0, 257);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(368, 41);
            this.lblRem.TabIndex = 1;
            this.lblRem.Text = "Balance : 0.00";
            this.lblRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(28, 40);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(117, 21);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Enter Amount : ";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblCardMsg);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(368, 298);
            this.pnlCard.TabIndex = 0;
            // 
            // lblCardMsg
            // 
            this.lblCardMsg.AutoSize = true;
            this.lblCardMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMsg.Location = new System.Drawing.Point(37, 40);
            this.lblCardMsg.Name = "lblCardMsg";
            this.lblCardMsg.Size = new System.Drawing.Size(268, 21);
            this.lblCardMsg.TabIndex = 0;
            this.lblCardMsg.Text = "Click on Pay to complete your order...";
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblBase);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(504, 419);
            this.tblBase.ResumeLayout(false);
            this.tblBase.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Label lblCardMsg;
        private System.Windows.Forms.Button btnExactAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblRem;
        private System.Windows.Forms.Label lblAmount;
    }
}