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
        
        long selectedId = -1;
        public Management()
        {
            InitializeComponent();
            Filter_cmb.SelectedIndex = 0;
            gd_management.Columns["Quantity"].Width = 52;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            gd_management.DataSource = DataStorage.Medicines;
            gd_management.ReadOnly = true;
            gd_management.ColumnHeadersHeight = 28;
            gd_management.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_txt.Text) || string.IsNullOrWhiteSpace(ScientificName_txt.Text) || string.IsNullOrWhiteSpace(Manufacturer_txt.Text) || string.IsNullOrWhiteSpace(Price_txt.Text) || string.IsNullOrWhiteSpace(Quantity_txt.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string n = Name_txt.Text.Trim();
            string sn = ScientificName_txt.Text.Trim();
            string m = Manufacturer_txt.Text.Trim();
            double p = double.Parse(Price_txt.Text.Trim());
            int q = int.Parse(Quantity_txt.Text.Trim());
            DateTime d = DateTime.Parse(dt_picker.Text.Trim());
            long id = long.Parse(Id_txt.Text.Trim());

            if(q <= 0) { 
                MessageBox.Show("Invalid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medicine med = new Medicine(n, sn, m, p, q, d, id);


            foreach (Medicine temp in DataStorage.Medicines) // التحقق انه مو موجود مسبقا
            {
                if (med.Id == temp.Id)
                {
                    MessageBox.Show("A medicine with the same ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (Medicine temp in DataStorage.Medicines)
            {
                if (med.Name ==  temp.Name)
                    {
                    MessageBox.Show("A medicine with the same Name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataStorage.Medicines.Add(med);

            await RunStatusSequence();
            Helper.Refresh(gd_management);

        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
           
            foreach (Medicine med in DataStorage.Medicines)
            {
                if (med.Id == selectedId)
                {
                    med.Name = Name_txt.Text.Trim();
                    med.ScientificName = ScientificName_txt.Text.Trim();
                    med.Manufacturer = Manufacturer_txt.Text.Trim();
                    med.Price = double.Parse(Price_txt.Text.Trim());
                    med.Quantity = int.Parse(Quantity_txt.Text.Trim());
                    med.ExpiryDate = DateTime.Parse(dt_picker.Text.Trim());
                    med.Id = long.Parse(Id_txt.Text.Trim());
                    break;
                }
            }

            await RunStatusSequence();
            Helper.Refresh(gd_management);
        }

        private void gd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = long.Parse(gd_management.CurrentRow.Cells["Id"].Value.ToString());
            Id_txt.Text = gd_management.CurrentRow.Cells["Id"].Value.ToString();

            Name_txt.Text = gd_management.CurrentRow.Cells["Name"].Value.ToString();
            ScientificName_txt.Text = gd_management.CurrentRow.Cells["ScientificName"].Value.ToString();
            Manufacturer_txt.Text = gd_management.CurrentRow.Cells["Manufacturer"].Value.ToString();
            Price_txt.Text = gd_management.CurrentRow.Cells["Price"].Value.ToString();
            Quantity_txt.Text = gd_management.CurrentRow.Cells["Quantity"].Value.ToString();
            dt_picker.Value = DateTime.Parse(gd_management.CurrentRow.Cells["ExpiryDate"].Value.ToString());
        }

        private async void remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            await RunStatusSequence();
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
            Id_txt.Clear();
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.DimGray;
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.Red;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.FillColor = Color.Red;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.FillColor = Color.DodgerBlue;
        }


        // دالة المؤقت
        private async Task RunStatusSequence()
        {
            // تشغيل المرحلة الأولى
            status_lbl.Text = "Processing...";
            status_lbl.ForeColor = Color.Orange;
            status_lbl.Visible = true;

            // انتظر لمدة 2 ثانية
            await Task.Delay(2000);

            // تشغيل المرحلة الثانية
            status_lbl.Text = "Done!";
            status_lbl.ForeColor = Color.Green;

            // انتظر لمدة 2 ثانية أخرى
            await Task.Delay(2000);

            //  إخفاء الـ Label
            status_lbl.Visible = false;
        }
    }
}
