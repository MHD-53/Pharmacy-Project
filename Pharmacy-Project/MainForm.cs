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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Show_dataGridView.DataSource = DataStorage.Medicines;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Medicine> result = new List<Medicine>(DataStorage.Medicines);
            switch (cmbFilter.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < result.Count; i++)
                    {
                       for (int j = i + 1; j < result.Count; j++)
                        {
                            if (string.Compare(result[i].Manufactuere, result[j].Manufactuere) > 0)
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

            Show_dataGridView.DataSource = null;
            Show_dataGridView.DataSource = result;
        }
    }
}
