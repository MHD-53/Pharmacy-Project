namespace Pharmacy_Project
{
    partial class ExpiredMedicinesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ex_gd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.destroy_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btnEX = new Guna.UI2.WinForms.Guna2Button();
            this.btnMG = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.NameGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScientificName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ex_gd)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ex_gd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ex_gd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ex_gd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ex_gd.ColumnHeadersHeight = 19;
            this.ex_gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ex_gd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameGD,
            this.Manufacturer,
            this.ScientificName,
            this.Quantity,
            this.Price,
            this.ExpiryDate,
            this.IdCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ex_gd.DefaultCellStyle = dataGridViewCellStyle3;
            this.ex_gd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ex_gd.Location = new System.Drawing.Point(191, 73);
            this.ex_gd.Name = "ex_gd";
            this.ex_gd.RowHeadersVisible = false;
            this.ex_gd.RowHeadersWidth = 51;
            this.ex_gd.RowTemplate.Height = 26;
            this.ex_gd.Size = new System.Drawing.Size(987, 481);
            this.ex_gd.TabIndex = 6;
            this.ex_gd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ex_gd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ex_gd.ThemeStyle.HeaderStyle.Height = 19;
            this.ex_gd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ex_gd.ThemeStyle.RowsStyle.Height = 26;
            // 
            // destroy_btn
            // 
            this.destroy_btn.BorderRadius = 20;
            this.destroy_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.destroy_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.destroy_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.destroy_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.destroy_btn.Font = new System.Drawing.Font("Monotype Koufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.destroy_btn.ForeColor = System.Drawing.Color.White;
            this.destroy_btn.Location = new System.Drawing.Point(532, 571);
            this.destroy_btn.Name = "destroy_btn";
            this.destroy_btn.Size = new System.Drawing.Size(275, 54);
            this.destroy_btn.TabIndex = 7;
            this.destroy_btn.Text = "Destroy";
            this.destroy_btn.Click += new System.EventHandler(this.destroy_btn_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(1109, -3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 46);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-1, -3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1179, 76);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Destroy Expired Medicines";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.logout_btn);
            this.guna2Panel1.Controls.Add(this.btnEX);
            this.guna2Panel1.Controls.Add(this.btnMG);
            this.guna2Panel1.Controls.Add(this.btnPOS);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(195, 565);
            this.guna2Panel1.TabIndex = 26;
            // 
            // logout_btn
            // 
            this.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_btn.FillColor = System.Drawing.Color.DimGray;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(-3, 520);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(198, 45);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Log out";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseEnter += new System.EventHandler(this.logout_btn_MouseEnter);
            this.logout_btn.MouseLeave += new System.EventHandler(this.logout_btn_MouseLeave);
            // 
            // btnEX
            // 
            this.btnEX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEX.FillColor = System.Drawing.Color.Turquoise;
            this.btnEX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEX.ForeColor = System.Drawing.Color.White;
            this.btnEX.Location = new System.Drawing.Point(0, 126);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(195, 84);
            this.btnEX.TabIndex = 2;
            this.btnEX.Text = "Expired Medicines";
            // 
            // btnMG
            // 
            this.btnMG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMG.FillColor = System.Drawing.Color.Black;
            this.btnMG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMG.ForeColor = System.Drawing.Color.White;
            this.btnMG.Location = new System.Drawing.Point(0, 58);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(195, 71);
            this.btnMG.TabIndex = 1;
            this.btnMG.Text = "Management";
            this.btnMG.Click += new System.EventHandler(this.btnMG_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOS.FillColor = System.Drawing.Color.Black;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(0, 0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(195, 61);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "POS";
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // NameGD
            // 
            this.NameGD.DataPropertyName = "Name";
            this.NameGD.HeaderText = "Name";
            this.NameGD.MinimumWidth = 6;
            this.NameGD.Name = "NameGD";
            this.NameGD.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // ScientificName
            // 
            this.ScientificName.DataPropertyName = "ScientificName";
            this.ScientificName.HeaderText = "ScientificName";
            this.ScientificName.MinimumWidth = 6;
            this.ScientificName.Name = "ScientificName";
            this.ScientificName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "ExpiryDate";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "Id";
            this.IdCol.HeaderText = "Id";
            this.IdCol.MinimumWidth = 6;
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // ExpiredMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.destroy_btn);
            this.Controls.Add(this.ex_gd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiredMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiredMedicinesForm";
            this.Load += new System.EventHandler(this.ExpiredMedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ex_gd)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView ex_gd;
        private Guna.UI2.WinForms.Guna2Button destroy_btn;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEX;
        private Guna.UI2.WinForms.Guna2Button btnMG;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScientificName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
    }
}