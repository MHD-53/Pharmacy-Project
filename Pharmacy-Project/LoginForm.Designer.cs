namespace Pharmacy_Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(450, 228);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Go";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(436, 116);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 24);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(436, 169);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 24);
            this.txt_password.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login page";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
    }
}

