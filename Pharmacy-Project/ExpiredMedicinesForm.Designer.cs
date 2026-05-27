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
            this.REMOVEbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMG = new System.Windows.Forms.Button();
            this.btnEX = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exGD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exGD
            // 
            this.exGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exGD.Location = new System.Drawing.Point(247, 101);
            this.exGD.Name = "exGD";
            this.exGD.RowHeadersWidth = 51;
            this.exGD.RowTemplate.Height = 26;
            this.exGD.Size = new System.Drawing.Size(742, 324);
            this.exGD.TabIndex = 0;
            // 
            // REMOVEbtn
            // 
            this.REMOVEbtn.Location = new System.Drawing.Point(551, 491);
            this.REMOVEbtn.Name = "REMOVEbtn";
            this.REMOVEbtn.Size = new System.Drawing.Size(179, 84);
            this.REMOVEbtn.TabIndex = 1;
            this.REMOVEbtn.Text = "اتلف";
            this.REMOVEbtn.UseVisualStyleBackColor = true;
            this.REMOVEbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(941, 52);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnMG);
            this.panel1.Controls.Add(this.btnEX);
            this.panel1.Controls.Add(this.btnPOS);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 5;
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
            this.btnEX.Click += new System.EventHandler(this.btnEX_Click_1);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(24, 13);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(127, 108);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click_1);
            // 
            // ExpiredMedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.REMOVEbtn);
            this.Controls.Add(this.exGD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiredMedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiredMedicinesForm";
            this.Load += new System.EventHandler(this.ExpiredMedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exGD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exGD;
        private System.Windows.Forms.Button REMOVEbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.Button btnEX;
        private System.Windows.Forms.Button btnPOS;
    }
}