using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(Login.CheckUser(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login successful!");
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
                main.FormClosed += (s, args) => Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
