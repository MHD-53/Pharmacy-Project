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
    public partial class Management : Form
    {
        int Idindex = 10;
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            gd.DataSource = DataStorage.Medicines;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string sn = textBox2.Text;
            string m = textBox3.Text;
            double p = double.Parse(textBox4.Text);
            int q = int.Parse(textBox5.Text);
            DateTime d = DateTime.Parse(dt.Text);

            Medicine med = new Medicine(n, sn, m, p, q,d, Idindex);

            DataStorage.Medicines.Add(med);
            Idindex++;

            gd.DataSource = null;
            gd.DataSource = DataStorage.Medicines;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
