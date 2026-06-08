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
    public partial class ExpiredMedicinesForm : Form
    {
        public ExpiredMedicinesForm()
        {
            InitializeComponent();

            ex_gd.DefaultCellStyle.Font = new Font("Arial", 12);
            ex_gd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            ex_gd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ex_gd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ExpiredMedicinesForm_Load(object sender, EventArgs e)
        {
            ex_gd.AutoGenerateColumns = false;
            
            List<Medicine> expired = new List<Medicine>();
            for (int i = 0; i < DataStorage.Medicines.Count; i++)
            {
                if (DataStorage.Medicines[i].ExpiryDate < DateTime.Now)
                {
                    expired.Add(DataStorage.Medicines[i]);
                }
            } 
            
            ex_gd.DataSource = expired;
           
        }

        private void destroy_btn_Click(object sender, EventArgs e)
        {
            for (int i = DataStorage.Medicines.Count -1; i >= 0; i--)
            {
                if (DataStorage.Medicines[i].ExpiryDate < DateTime.Now)
                {
                    DataStorage.Medicines.RemoveAt(i);
                }
            }
            MessageBox.Show("Expired medicines have been removed.", "sucess", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            Management manage = new Management();
            manage.Show();
            this.Close();
        }

        

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm pos = new POSForm();
            pos.Show();
            this.Close();
        }

        private void btnMG_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            management.Show();
            this.Close();
        }

       

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.Red;
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.DimGray;
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
