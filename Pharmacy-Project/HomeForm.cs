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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagemenM management = new ManagemenM();
            management.ShowDialog();
        }
    }
}
