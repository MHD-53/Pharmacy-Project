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
            this.gd = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.update_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMG = new System.Windows.Forms.Button();
            this.btnEX = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gd
            // 
            this.gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd.Location = new System.Drawing.Point(265, 63);
            this.gd.Name = "gd";
            this.gd.RowHeadersWidth = 51;
            this.gd.RowTemplate.Height = 26;
            this.gd.Size = new System.Drawing.Size(504, 303);
            this.gd.TabIndex = 0;
            this.gd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_CellClick);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(242, 438);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(820, 87);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 24);
            this.textBoxN.TabIndex = 2;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(831, 262);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 24);
            this.textBoxP.TabIndex = 3;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(820, 199);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 24);
            this.textBoxM.TabIndex = 4;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(807, 129);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 24);
            this.textBoxS.TabIndex = 5;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(831, 311);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 24);
            this.textBoxQ.TabIndex = 6;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(775, 366);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 24);
            this.dt.TabIndex = 7;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(333, 439);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(476, 438);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 9;
            this.remove_btn.Text = "remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1016, 47);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
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
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 11;
            // 
            // btnMG
            // 
            this.btnMG.Location = new System.Drawing.Point(24, 127);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(127, 108);
            this.btnMG.TabIndex = 4;
            this.btnMG.Text = "Management";
            this.btnMG.UseVisualStyleBackColor = true;
            this.btnMG.Click += new System.EventHandler(this.btnMG_Click_1);
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
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.gd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gd;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.Button btnEX;
        private System.Windows.Forms.Button btnPOS;
    }
}