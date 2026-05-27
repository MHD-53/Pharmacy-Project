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
            this.exGD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exGD)).BeginInit();
            this.SuspendLayout();
            // 
            // exGD
            // 
            this.exGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exGD.Location = new System.Drawing.Point(25, 12);
            this.exGD.Name = "exGD";
            this.exGD.RowHeadersWidth = 51;
            this.exGD.RowTemplate.Height = 26;
            this.exGD.Size = new System.Drawing.Size(784, 324);
            this.exGD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "اتلف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExpiredMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exGD);
            this.Name = "ExpiredMedicinesForm";
            this.Text = "ExpiredMedicinesForm";
            this.Load += new System.EventHandler(this.ExpiredMedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exGD;
        private System.Windows.Forms.Button button1;
    }
}