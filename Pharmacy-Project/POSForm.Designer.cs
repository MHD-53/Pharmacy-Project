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
            this.Show_dataGridView = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.Cart_dataGridView = new System.Windows.Forms.DataGridView();
            this.btnBUY = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMG = new System.Windows.Forms.Button();
            this.btnEX = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show_dataGridView
            // 
            this.Show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_dataGridView.Location = new System.Drawing.Point(246, 12);
            this.Show_dataGridView.Name = "Show_dataGridView";
            this.Show_dataGridView.RowHeadersWidth = 51;
            this.Show_dataGridView.RowTemplate.Height = 26;
            this.Show_dataGridView.Size = new System.Drawing.Size(821, 314);
            this.Show_dataGridView.TabIndex = 0;
            this.Show_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_dataGridView_CellContentClick);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "اسم الشركة",
            "السعر",
            "تاريخ الصلاحية"});
            this.cmbFilter.Location = new System.Drawing.Point(782, 364);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(214, 24);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // Cart_dataGridView
            // 
            this.Cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cart_dataGridView.Location = new System.Drawing.Point(246, 332);
            this.Cart_dataGridView.Name = "Cart_dataGridView";
            this.Cart_dataGridView.RowHeadersWidth = 51;
            this.Cart_dataGridView.RowTemplate.Height = 26;
            this.Cart_dataGridView.Size = new System.Drawing.Size(454, 258);
            this.Cart_dataGridView.TabIndex = 2;
            // 
            // btnBUY
            // 
            this.btnBUY.Location = new System.Drawing.Point(764, 448);
            this.btnBUY.Name = "btnBUY";
            this.btnBUY.Size = new System.Drawing.Size(127, 59);
            this.btnBUY.TabIndex = 3;
            this.btnBUY.Text = "Add to Cart";
            this.btnBUY.UseVisualStyleBackColor = true;
            this.btnBUY.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnMG);
            this.panel1.Controls.Add(this.btnEX);
            this.panel1.Controls.Add(this.btnPOS);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 4;
            // 
            // btnMG
            // 
            this.btnMG.Location = new System.Drawing.Point(24, 127);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(127, 108);
            this.btnMG.TabIndex = 4;
            this.btnMG.Text = "Management";
            this.btnMG.UseVisualStyleBackColor = true;
            this.btnMG.Click += new System.EventHandler(this.btnMG_Click);
            // 
            // btnEX
            // 
            this.btnEX.Location = new System.Drawing.Point(24, 241);
            this.btnEX.Name = "btnEX";
            this.btnEX.Size = new System.Drawing.Size(127, 108);
            this.btnEX.TabIndex = 3;
            this.btnEX.Text = "Ex";
            this.btnEX.UseVisualStyleBackColor = true;
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(24, 13);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(127, 108);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1157, 68);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 655);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBUY);
            this.Controls.Add(this.Cart_dataGridView);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.Show_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridView Cart_dataGridView;
        private System.Windows.Forms.Button btnBUY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.Button btnEX;
    }
}