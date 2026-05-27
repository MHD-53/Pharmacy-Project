namespace Pharmacy_Project
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_dataGridView
            // 
            this.Show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_dataGridView.Location = new System.Drawing.Point(27, 40);
            this.Show_dataGridView.Name = "Show_dataGridView";
            this.Show_dataGridView.RowHeadersWidth = 51;
            this.Show_dataGridView.RowTemplate.Height = 26;
            this.Show_dataGridView.Size = new System.Drawing.Size(759, 314);
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
            this.cmbFilter.Location = new System.Drawing.Point(854, 67);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(214, 24);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // Cart_dataGridView
            // 
            this.Cart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cart_dataGridView.Location = new System.Drawing.Point(27, 385);
            this.Cart_dataGridView.Name = "Cart_dataGridView";
            this.Cart_dataGridView.RowHeadersWidth = 51;
            this.Cart_dataGridView.RowTemplate.Height = 26;
            this.Cart_dataGridView.Size = new System.Drawing.Size(392, 258);
            this.Cart_dataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cart_dataGridView);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.Show_dataGridView);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Show_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Show_dataGridView;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridView Cart_dataGridView;
        private System.Windows.Forms.Button button1;
    }
}