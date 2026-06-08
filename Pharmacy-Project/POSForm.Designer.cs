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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btnEX = new Guna.UI2.WinForms.Guna2Button();
            this.btnMG = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.AddToCart_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Cart_dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Buy_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SelectedID_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Qu_NumUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbl_wrongId = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qu_NumUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.guna2HtmlLabel1.Text = "Point Of Sale";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
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
            // AddToCart_btn
            // 
            this.AddToCart_btn.BorderRadius = 20;
            this.AddToCart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddToCart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddToCart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddToCart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddToCart_btn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCart_btn.ForeColor = System.Drawing.Color.White;
            this.AddToCart_btn.Location = new System.Drawing.Point(725, 115);
            this.AddToCart_btn.Name = "AddToCart_btn";
            this.AddToCart_btn.Size = new System.Drawing.Size(180, 45);
            this.AddToCart_btn.TabIndex = 30;
            this.AddToCart_btn.Text = "Add to Cart";
            this.AddToCart_btn.Click += new System.EventHandler(this.AddToCart_btn_Click);
            // 
            // Cart_dataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Cart_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cart_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Cart_dataGridView.ColumnHeadersHeight = 4;
            this.Cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cart_dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.Cart_dataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.Cart_dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Cart_dataGridView.ThemeStyle.RowsStyle.Height = 26;
            // 
            // Buy_btn
            // 
            this.Buy_btn.BorderColor = System.Drawing.Color.Aqua;
            this.Buy_btn.BorderRadius = 30;
            this.Buy_btn.BorderThickness = 1;
            this.Buy_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Buy_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Buy_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Buy_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Buy_btn.Font = new System.Drawing.Font("Unispace", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_btn.ForeColor = System.Drawing.Color.White;
            this.Buy_btn.Location = new System.Drawing.Point(985, 512);
            this.Buy_btn.Name = "Buy_btn";
            this.Buy_btn.Size = new System.Drawing.Size(180, 97);
            this.Buy_btn.TabIndex = 32;
            this.Buy_btn.Text = "Buy";
            this.Buy_btn.Click += new System.EventHandler(this.Buy_btn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(222, 131);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(203, 18);
            this.guna2HtmlLabel2.TabIndex = 33;
            this.guna2HtmlLabel2.Text = "Enter the ID here:";
            // 
            // SelectedID_txt
            // 
            this.SelectedID_txt.BorderRadius = 16;
            this.SelectedID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SelectedID_txt.DefaultText = "";
            this.SelectedID_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SelectedID_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SelectedID_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedID_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SelectedID_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedID_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedID_txt.ForeColor = System.Drawing.Color.Black;
            this.SelectedID_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectedID_txt.Location = new System.Drawing.Point(431, 115);
            this.SelectedID_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedID_txt.MaxLength = 30000000;
            this.SelectedID_txt.Name = "SelectedID_txt";
            this.SelectedID_txt.PlaceholderText = "";
            this.SelectedID_txt.SelectedText = "";
            this.SelectedID_txt.Size = new System.Drawing.Size(154, 48);
            this.SelectedID_txt.TabIndex = 35;
            this.SelectedID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedID_txt_KeyPress);
            // 
            // Qu_NumUpDown
            // 
            this.Qu_NumUpDown.BackColor = System.Drawing.Color.Transparent;
            this.Qu_NumUpDown.BorderRadius = 20;
            this.Qu_NumUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qu_NumUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Qu_NumUpDown.Location = new System.Drawing.Point(591, 115);
            this.Qu_NumUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Qu_NumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qu_NumUpDown.Name = "Qu_NumUpDown";
            this.Qu_NumUpDown.Size = new System.Drawing.Size(114, 48);
            this.Qu_NumUpDown.TabIndex = 36;
            this.Qu_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_wrongId
            // 
            this.lbl_wrongId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wrongId.ForeColor = System.Drawing.Color.Red;
            this.lbl_wrongId.Location = new System.Drawing.Point(410, 167);
            this.lbl_wrongId.Name = "lbl_wrongId";
            this.lbl_wrongId.Size = new System.Drawing.Size(207, 29);
            this.lbl_wrongId.TabIndex = 37;
            this.lbl_wrongId.Text = "Medicine Not Found.";
            this.lbl_wrongId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_wrongId.Visible = false;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.lbl_wrongId);
            this.Controls.Add(this.Qu_NumUpDown);
            this.Controls.Add(this.SelectedID_txt);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.Buy_btn);
            this.Controls.Add(this.Cart_dataGridView);
            this.Controls.Add(this.AddToCart_btn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qu_NumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEX;
        private Guna.UI2.WinForms.Guna2Button btnMG;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2Button AddToCart_btn;
        private Guna.UI2.WinForms.Guna2DataGridView Cart_dataGridView;
        private Guna.UI2.WinForms.Guna2Button Buy_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox SelectedID_txt;
        private Guna.UI2.WinForms.Guna2NumericUpDown Qu_NumUpDown;
        private System.Windows.Forms.Label lbl_wrongId;
    }
}