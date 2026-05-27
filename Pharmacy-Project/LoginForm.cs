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

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (Login.CheckUser(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login successful!");
                POSForm pos = new POSForm();
                this.Hide();
                
                pos.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}

