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
        }

        private void ExpiredMedicinesForm_Load(object sender, EventArgs e)
        {
            List<Medicine> expired = new List<Medicine>();
            for (int i = 0; i < DataStorage.Medicines.Count; i++)
            {
                if (DataStorage.Medicines[i].ExpiryDate < DateTime.Now)
                {
                    expired.Add(DataStorage.Medicines[i]);
                }
            } 
            
            exGD.DataSource = expired;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = DataStorage.Medicines.Count -1; i >= 0; i--)
            {
                if (DataStorage.Medicines[i].ExpiryDate < DateTime.Now)
                {
                    DataStorage.Medicines.RemoveAt(i);
                }
            }
            MessageBox.Show("Expired medicines have been removed.");
            this.Close();
        }
    }
}
