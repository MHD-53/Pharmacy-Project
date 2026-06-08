using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Login.CheckUser(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Management manage = new Management();
                this.Hide();
                manage.Show();
            }
            else
            {
                lbl_wrongUser.Visible = true;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.FillColor = Color.Red;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.FillColor = Color.DodgerBlue;
        }
    }
}

