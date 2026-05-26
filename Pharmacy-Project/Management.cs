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
    public partial class ManagemenM : Form
    {
        int Idindex = 10;
        int selectedId = -1;
        public ManagemenM()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            gd.DataSource = DataStorage.Medicines;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string n = textBoxN.Text;
            string sn = textBoxS.Text;
            string m = textBoxM.Text;
            double p = double.Parse(textBoxP.Text);
            int q = int.Parse(textBoxQ.Text);
            DateTime d = DateTime.Parse(dt.Text);

            Medicine med = new Medicine(n, sn, m, p, q,d, Idindex);

            DataStorage.Medicines.Add(med);
            Idindex++;

            Helper.Refresh(gd);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            foreach (Medicine med in DataStorage.Medicines)
            {
                if (med.Id == selectedId)
                {
                    med.Name = textBoxN.Text;
                    med.ScientificName = textBoxS.Text;
                    med.Manufacturer = textBoxM.Text;
                    med.Price = double.Parse(textBoxP.Text);
                    med.Quantity = int.Parse(textBoxQ.Text);
                    med.ExpiryDate = DateTime.Parse(dt.Text);
                    break;
                }
            }
            
            Helper.Refresh(gd);
        }

        private void gd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId    = int.Parse(gd.CurrentRow.Cells["Id"].Value.ToString());
            textBoxN.Text = gd.CurrentRow.Cells["Name"].Value.ToString();
            textBoxS.Text = gd.CurrentRow.Cells["ScientificName"].Value.ToString();
            textBoxM.Text = gd.CurrentRow.Cells["Manufacturer"].Value.ToString();
            textBoxP.Text = gd.CurrentRow.Cells["Price"].Value.ToString();
            textBoxQ.Text = gd.CurrentRow.Cells["Quantity"].Value.ToString();
            dt.Value = DateTime.Parse(gd.CurrentRow.Cells["ExpiryDate"].Value.ToString());
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            Medicine medToDelet = null;
            foreach (Medicine med in DataStorage.Medicines)
            {
                if (med.Id == selectedId)
                {
                    medToDelet = med;
                    break;
                }
            }

            DataStorage.Medicines.Remove(medToDelet);
            Helper.Refresh(gd);
        }
    }
}
