namespace Pharmacy_Project
{
    partial class POSForm
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
            this.btnBUY = new System.Windows.Forms.Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEX = new Guna.UI2.WinForms.Guna2Button();
            this.btnMG = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SelectedID_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Cart_dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBUY
            // 
            this.btnBUY.Location = new System.Drawing.Point(983, 539);
            this.btnBUY.Name = "btnBUY";
            this.btnBUY.Size = new System.Drawing.Size(127, 59);
            this.btnBUY.TabIndex = 3;
            this.btnBUY.Text = "Buy";
            this.btnBUY.UseVisualStyleBackColor = true;
            this.btnBUY.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1179, 76);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Buy a medicine";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_exit.Location = new System.Drawing.Point(1109, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 46);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.guna2Panel1.TabIndex = 27;
            // 
            // btnEX
            // 
            this.btnEX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEX.FillColor = System.Drawing.Color.Black;
            this.btnEX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEX.ForeColor = System.Drawing.Color.White;
            this.btnEX.Location = new System.Drawing.Point(0, 126);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(195, 84);
            this.btnEX.TabIndex = 2;
            this.btnEX.Text = "Expired Medicines";
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
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
            this.btnPOS.FillColor = System.Drawing.Color.Turquoise;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(0, 0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(195, 61);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "POS";
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
            this.logout_btn.Location = new System.Drawing.Point(0, 520);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(195, 45);
            this.logout_btn.TabIndex = 28;
            this.logout_btn.Text = "Log out";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseEnter += new System.EventHandler(this.logout_btn_MouseEnter);
            this.logout_btn.MouseLeave += new System.EventHandler(this.logout_btn_MouseLeave);
            // 
            // SelectedID_txt
            // 
            this.SelectedID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectedID_txt.DefaultText = "";
            this.SelectedID_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SelectedID_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SelectedID_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedID_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedID_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedID_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedID_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedID_txt.Location = new System.Drawing.Point(686, 113);
            this.SelectedID_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedID_txt.Name = "SelectedID_txt";
            this.SelectedID_txt.PlaceholderText = "";
            this.SelectedID_txt.SelectedText = "";
            this.SelectedID_txt.Size = new System.Drawing.Size(229, 48);
            this.SelectedID_txt.TabIndex = 29;
            this.SelectedID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedID_txt_KeyPress);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(451, 116);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Add to Cart";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Cart_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Cart_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cart_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cart_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Cart_dataGridView.Location = new System.Drawing.Point(222, 199);
            this.Cart_dataGridView.Name = "Cart_dataGridView";
            this.Cart_dataGridView.RowHeadersVisible = false;
            this.Cart_dataGridView.RowHeadersWidth = 51;
            this.Cart_dataGridView.RowTemplate.Height = 26;
            this.Cart_dataGridView.Size = new System.Drawing.Size(743, 410);
            this.Cart_dataGridView.TabIndex = 31;
            this.Cart_dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Cart_dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Cart_dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cart_dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.Cart_dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Cart_dataGridView.ThemeStyle.RowsStyle.Height = 26;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.Cart_dataGridView);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.SelectedID_txt);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnBUY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBUY;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEX;
        private Guna.UI2.WinForms.Guna2Button btnMG;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2TextBox SelectedID_txt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView Cart_dataGridView;
    }
}