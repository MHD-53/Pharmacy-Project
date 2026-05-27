namespace Pharmacy_Project
{
    partial class InvoiceForm
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
            this.Invoice_dataGridView = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoice_dataGridView
            // 
            this.Invoice_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_dataGridView.Location = new System.Drawing.Point(150, 47);
            this.Invoice_dataGridView.Name = "Invoice_dataGridView";
            this.Invoice_dataGridView.RowHeadersWidth = 51;
            this.Invoice_dataGridView.RowTemplate.Height = 26;
            this.Invoice_dataGridView.Size = new System.Drawing.Size(454, 224);
            this.Invoice_dataGridView.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(562, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(562, 358);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Invoice_dataGridView);
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Invoice_dataGridView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button button1;
    }
}