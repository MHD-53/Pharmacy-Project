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
        int selectedId = -1;
        public Management()
        {
            InitializeComponent();
            Filter_cmb.SelectedIndex = 0;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            gd_management.DataSource = DataStorage.Medicines;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string n = Name_txt.Text;
            string sn = ScientificName_txt.Text;
            string m = Manufacturer_txt.Text;
            double p = double.Parse(Price_txt.Text);
            int q = int.Parse(Quantity_txt.Text);
            DateTime d = DateTime.Parse(dt_picker.Text);

            Medicine med = new Medicine(n, sn, m, p, q, d, Idindex);

            DataStorage.Medicines.Add(med);
            Idindex++;

            Helper.Refresh(gd_management);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            foreach (Medicine med in DataStorage.Medicines)
            {
                if (med.Id == selectedId)
                {
                    med.Name = Name_txt.Text;
                    med.ScientificName = ScientificName_txt.Text;
                    med.Manufacturer = Manufacturer_txt.Text;
                    med.Price = double.Parse(Price_txt.Text);
                    med.Quantity = int.Parse(Quantity_txt.Text);
                    med.ExpiryDate = DateTime.Parse(dt_picker.Text);
                    break;
                }
            }

            Helper.Refresh(gd_management);
        }

        private void gd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(gd_management.CurrentRow.Cells["Id"].Value.ToString());
            Name_txt.Text = gd_management.CurrentRow.Cells["Name"].Value.ToString();
            ScientificName_txt.Text = gd_management.CurrentRow.Cells["ScientificName"].Value.ToString();
            Manufacturer_txt.Text = gd_management.CurrentRow.Cells["Manufacturer"].Value.ToString();
            Price_txt.Text = gd_management.CurrentRow.Cells["Price"].Value.ToString();
            Quantity_txt.Text = gd_management.CurrentRow.Cells["Quantity"].Value.ToString();
            dt_picker.Value = DateTime.Parse(gd_management.CurrentRow.Cells["ExpiryDate"].Value.ToString());
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

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
            Helper.Refresh(gd_management);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm pos = new POSForm();
            pos.Show();
            this.Close();
        }

        private void btnMG_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            ExpiredMedicinesForm exp = new ExpiredMedicinesForm();
            exp.Show();
            this.Close();
        }

        private void Filter_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Medicine> result = new List<Medicine>(DataStorage.Medicines);
            switch (Filter_cmb.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < result.Count; i++)
                    {
                        for (int j = i + 1; j < result.Count; j++)
                        {
                            if (string.Compare(result[i].Manufacturer, result[j].Manufacturer) > 0)
                            {
                                Medicine temp = result[i];
                                result[i] = result[j];
                                result[j] = temp;
                            }
                        }
                    }
                    break;

                case 1:
                    result = result.OrderBy(m => m.Price).ToList();
                    break;


                case 2:
                    result = result.OrderBy(m => m.ExpiryDate).ToList();
                    break;
            }

            gd_management.DataSource = null;
            gd_management.DataSource = result;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Name_txt.Clear();
            ScientificName_txt.Clear();
            Manufacturer_txt.Clear();
            Price_txt.Clear();
            Quantity_txt.Clear();
            dt_picker.Value = DateTime.Now;
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.DimGray;
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.Red;
        }
    }
}
