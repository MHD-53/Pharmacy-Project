namespace Pharmacy_Project
{
    partial class Management
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
            this.Exitbtn = new System.Windows.Forms.Button();
            this.gd_management = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Filter_cmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.remove_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Manufacturer_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ScientificName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Price_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quantity_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.dt_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.btnEX = new Guna.UI2.WinForms.Guna2Button();
            this.btnMG = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Ex_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.qu_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Sname_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.man_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pri_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.Id_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gd_management)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1074, 27);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // gd_management
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gd_management.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gd_management.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gd_management.ColumnHeadersHeight = 4;
            this.gd_management.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gd_management.DefaultCellStyle = dataGridViewCellStyle3;
            this.gd_management.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gd_management.Location = new System.Drawing.Point(517, 142);
            this.gd_management.Name = "gd_management";
            this.gd_management.RowHeadersVisible = false;
            this.gd_management.RowHeadersWidth = 51;
            this.gd_management.RowTemplate.Height = 26;
            this.gd_management.Size = new System.Drawing.Size(648, 488);
            this.gd_management.TabIndex = 12;
            this.gd_management.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gd_management.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.gd_management.ThemeStyle.HeaderStyle.Height = 4;
            this.gd_management.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.gd_management.ThemeStyle.RowsStyle.Height = 26;
            this.gd_management.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_CellClick);
            // 
            // Filter_cmb
            // 
            this.Filter_cmb.BackColor = System.Drawing.Color.Transparent;
            this.Filter_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Filter_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_cmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_cmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_cmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Filter_cmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Filter_cmb.ItemHeight = 30;
            this.Filter_cmb.Items.AddRange(new object[] {
            "Manufacturer",
            "Price",
            "ExpiryDate"});
            this.Filter_cmb.Location = new System.Drawing.Point(604, 81);
            this.Filter_cmb.Name = "Filter_cmb";
            this.Filter_cmb.Size = new System.Drawing.Size(184, 36);
            this.Filter_cmb.TabIndex = 13;
            this.Filter_cmb.SelectedIndexChanged += new System.EventHandler(this.Filter_cmb_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.BorderRadius = 20;
            this.add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(7, 428);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(151, 45);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Add";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BorderRadius = 20;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(7, 488);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(152, 45);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BorderRadius = 20;
            this.remove_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Location = new System.Drawing.Point(169, 428);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(151, 45);
            this.remove_btn.TabIndex = 16;
            this.remove_btn.Text = "Remove";
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Name_txt.BorderRadius = 20;
            this.Name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_txt.DefaultText = "";
            this.Name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.ForeColor = System.Drawing.Color.Black;
            this.Name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Name_txt.Location = new System.Drawing.Point(120, 25);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PlaceholderText = "";
            this.Name_txt.SelectedText = "";
            this.Name_txt.Size = new System.Drawing.Size(180, 48);
            this.Name_txt.TabIndex = 17;
            // 
            // Manufacturer_txt
            // 
            this.Manufacturer_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Manufacturer_txt.BorderRadius = 20;
            this.Manufacturer_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Manufacturer_txt.DefaultText = "";
            this.Manufacturer_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Manufacturer_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Manufacturer_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Manufacturer_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Manufacturer_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Manufacturer_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer_txt.ForeColor = System.Drawing.Color.Black;
            this.Manufacturer_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Manufacturer_txt.Location = new System.Drawing.Point(120, 137);
            this.Manufacturer_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Manufacturer_txt.Name = "Manufacturer_txt";
            this.Manufacturer_txt.PlaceholderText = "";
            this.Manufacturer_txt.SelectedText = "";
            this.Manufacturer_txt.Size = new System.Drawing.Size(180, 48);
            this.Manufacturer_txt.TabIndex = 18;
            // 
            // ScientificName_txt
            // 
            this.ScientificName_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ScientificName_txt.BorderRadius = 20;
            this.ScientificName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScientificName_txt.DefaultText = "";
            this.ScientificName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ScientificName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ScientificName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScientificName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ScientificName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScientificName_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificName_txt.ForeColor = System.Drawing.Color.Black;
            this.ScientificName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScientificName_txt.Location = new System.Drawing.Point(120, 81);
            this.ScientificName_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScientificName_txt.Name = "ScientificName_txt";
            this.ScientificName_txt.PlaceholderText = "";
            this.ScientificName_txt.SelectedText = "";
            this.ScientificName_txt.Size = new System.Drawing.Size(180, 48);
            this.ScientificName_txt.TabIndex = 19;
            // 
            // Price_txt
            // 
            this.Price_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Price_txt.BorderRadius = 20;
            this.Price_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price_txt.DefaultText = "";
            this.Price_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Price_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Price_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_txt.ForeColor = System.Drawing.Color.Black;
            this.Price_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price_txt.Location = new System.Drawing.Point(120, 193);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.PlaceholderText = "";
            this.Price_txt.SelectedText = "";
            this.Price_txt.Size = new System.Drawing.Size(180, 48);
            this.Price_txt.TabIndex = 20;
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Quantity_txt.BorderRadius = 20;
            this.Quantity_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity_txt.DefaultText = "";
            this.Quantity_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Quantity_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Quantity_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantity_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantity_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantity_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txt.ForeColor = System.Drawing.Color.Black;
            this.Quantity_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantity_txt.Location = new System.Drawing.Point(120, 249);
            this.Quantity_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.PlaceholderText = "";
            this.Quantity_txt.SelectedText = "";
            this.Quantity_txt.Size = new System.Drawing.Size(180, 48);
            this.Quantity_txt.TabIndex = 21;
            // 
            // dt_picker
            // 
            this.dt_picker.BackColor = System.Drawing.Color.Transparent;
            this.dt_picker.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.dt_picker.BorderRadius = 20;
            this.dt_picker.BorderThickness = 1;
            this.dt_picker.Checked = true;
            this.dt_picker.FillColor = System.Drawing.Color.White;
            this.dt_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_picker.Location = new System.Drawing.Point(120, 312);
            this.dt_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(180, 36);
            this.dt_picker.TabIndex = 22;
            this.dt_picker.Value = new System.DateTime(2026, 6, 5, 6, 44, 40, 299);
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
            this.guna2Panel1.TabIndex = 23;
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
            this.logout_btn.TabIndex = 3;
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
            this.btnMG.FillColor = System.Drawing.Color.Turquoise;
            this.btnMG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMG.ForeColor = System.Drawing.Color.White;
            this.btnMG.Location = new System.Drawing.Point(0, 58);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(195, 71);
            this.btnMG.TabIndex = 1;
            this.btnMG.Text = "Management";
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1178, 76);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Manage Medicines";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.id_lbl);
            this.guna2Panel2.Controls.Add(this.Id_txt);
            this.guna2Panel2.Controls.Add(this.Clear_btn);
            this.guna2Panel2.Controls.Add(this.Ex_lbl);
            this.guna2Panel2.Controls.Add(this.qu_lbl);
            this.guna2Panel2.Controls.Add(this.Sname_lbl);
            this.guna2Panel2.Controls.Add(this.man_lbl);
            this.guna2Panel2.Controls.Add(this.pri_lbl);
            this.guna2Panel2.Controls.Add(this.name_lbl);
            this.guna2Panel2.Controls.Add(this.add_btn);
            this.guna2Panel2.Controls.Add(this.update_btn);
            this.guna2Panel2.Controls.Add(this.remove_btn);
            this.guna2Panel2.Controls.Add(this.dt_picker);
            this.guna2Panel2.Controls.Add(this.Name_txt);
            this.guna2Panel2.Controls.Add(this.Quantity_txt);
            this.guna2Panel2.Controls.Add(this.ScientificName_txt);
            this.guna2Panel2.Controls.Add(this.Price_txt);
            this.guna2Panel2.Controls.Add(this.Manufacturer_txt);
            this.guna2Panel2.Location = new System.Drawing.Point(191, 81);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(320, 555);
            this.guna2Panel2.TabIndex = 25;
            // 
            // Clear_btn
            // 
            this.Clear_btn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Clear_btn.BorderRadius = 20;
            this.Clear_btn.BorderThickness = 1;
            this.Clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clear_btn.FillColor = System.Drawing.Color.White;
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear_btn.Location = new System.Drawing.Point(165, 488);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(152, 45);
            this.Clear_btn.TabIndex = 29;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Ex_lbl
            // 
            this.Ex_lbl.AutoSize = false;
            this.Ex_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Ex_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_lbl.Location = new System.Drawing.Point(17, 307);
            this.Ex_lbl.Name = "Ex_lbl";
            this.Ex_lbl.Size = new System.Drawing.Size(92, 41);
            this.Ex_lbl.TabIndex = 28;
            this.Ex_lbl.Text = "Ex date:";
            this.Ex_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qu_lbl
            // 
            this.qu_lbl.AutoSize = false;
            this.qu_lbl.BackColor = System.Drawing.Color.Transparent;
            this.qu_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qu_lbl.Location = new System.Drawing.Point(17, 249);
            this.qu_lbl.Name = "qu_lbl";
            this.qu_lbl.Size = new System.Drawing.Size(92, 41);
            this.qu_lbl.TabIndex = 27;
            this.qu_lbl.Text = "Quantity:";
            this.qu_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sname_lbl
            // 
            this.Sname_lbl.AutoSize = false;
            this.Sname_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sname_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname_lbl.Location = new System.Drawing.Point(8, 81);
            this.Sname_lbl.Name = "Sname_lbl";
            this.Sname_lbl.Size = new System.Drawing.Size(106, 41);
            this.Sname_lbl.TabIndex = 26;
            this.Sname_lbl.Text = "Scientific:";
            this.Sname_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // man_lbl
            // 
            this.man_lbl.AutoSize = false;
            this.man_lbl.BackColor = System.Drawing.Color.Transparent;
            this.man_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.man_lbl.Location = new System.Drawing.Point(0, 137);
            this.man_lbl.Name = "man_lbl";
            this.man_lbl.Size = new System.Drawing.Size(120, 41);
            this.man_lbl.TabIndex = 25;
            this.man_lbl.Text = "Manufacture";
            this.man_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pri_lbl
            // 
            this.pri_lbl.AutoSize = false;
            this.pri_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pri_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pri_lbl.Location = new System.Drawing.Point(17, 193);
            this.pri_lbl.Name = "pri_lbl";
            this.pri_lbl.Size = new System.Drawing.Size(92, 41);
            this.pri_lbl.TabIndex = 24;
            this.pri_lbl.Text = "Price :";
            this.pri_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = false;
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(17, 25);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(92, 41);
            this.name_lbl.TabIndex = 23;
            this.name_lbl.Text = "Name :";
            this.name_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(531, 81);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel2.TabIndex = 26;
            this.guna2HtmlLabel2.Text = "Sort By:";
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
            this.btn_exit.Location = new System.Drawing.Point(1108, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 46);
            this.btn_exit.TabIndex = 27;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // Id_txt
            // 
            this.Id_txt.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Id_txt.BorderRadius = 20;
            this.Id_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_txt.DefaultText = "";
            this.Id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_txt.ForeColor = System.Drawing.Color.Black;
            this.Id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Id_txt.Location = new System.Drawing.Point(120, 364);
            this.Id_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.PlaceholderText = "";
            this.Id_txt.SelectedText = "";
            this.Id_txt.Size = new System.Drawing.Size(180, 48);
            this.Id_txt.TabIndex = 30;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = false;
            this.id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(17, 364);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(92, 41);
            this.id_lbl.TabIndex = 31;
            this.id_lbl.Text = "ID:";
            this.id_lbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 637);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Filter_cmb);
            this.Controls.Add(this.gd_management);
            this.Controls.Add(this.Exitbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_management)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exitbtn;
        private Guna.UI2.WinForms.Guna2DataGridView gd_management;
        private Guna.UI2.WinForms.Guna2ComboBox Filter_cmb;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2Button remove_btn;
        private Guna.UI2.WinForms.Guna2TextBox Name_txt;
        private Guna.UI2.WinForms.Guna2TextBox Manufacturer_txt;
        private Guna.UI2.WinForms.Guna2TextBox ScientificName_txt;
        private Guna.UI2.WinForms.Guna2TextBox Price_txt;
        private Guna.UI2.WinForms.Guna2TextBox Quantity_txt;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_picker;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEX;
        private Guna.UI2.WinForms.Guna2Button btnMG;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel name_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel qu_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sname_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel man_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel pri_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Ex_lbl;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button Clear_btn;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel id_lbl;
        private Guna.UI2.WinForms.Guna2TextBox Id_txt;
    }
}