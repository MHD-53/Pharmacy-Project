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
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
            
           

            Cart_dataGridView.AutoGenerateColumns = false;
            Cart_dataGridView.AllowUserToAddRows = false;
            Cart_dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Name";
            nameCol.ReadOnly = true;

            DataGridViewTextBoxColumn ScCol = new DataGridViewTextBoxColumn();
            ScCol.HeaderText = "Scientific Name";
            ScCol.ReadOnly = true;

            DataGridViewTextBoxColumn ManCol = new DataGridViewTextBoxColumn();
            ManCol.HeaderText = "Manufacturer";
            ManCol.ReadOnly = true;

            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.HeaderText = "Price";
            priceCol.ReadOnly = true;

            DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
            qtyCol.HeaderText = "Quantity";
            qtyCol.ReadOnly = false;

            Cart_dataGridView.Columns.Add(nameCol);
            Cart_dataGridView.Columns.Add(ScCol);
            Cart_dataGridView.Columns.Add(ManCol);
            Cart_dataGridView.Columns.Add(priceCol);
            Cart_dataGridView.Columns.Add(qtyCol);

            Cart_dataGridView.ColumnHeadersHeight= 28;

            Cart_dataGridView.DefaultCellStyle.Font = new Font("Arial", 12);
            Cart_dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            Cart_dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cart_dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }


        private void Buy_btn_Click(object sender, EventArgs e)
        {
       
            // التحقق أن السلة مو فارغة
            if (Cart_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("السلة فارغة!", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من الكميات أولا قبل أي عملية
            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                string medName = Cart_dataGridView.Rows[i].Cells[0].Value.ToString();
                if (Cart_dataGridView.Rows[i].Cells[4].Value == null || Cart_dataGridView.Rows[i].Cells[4].Value.ToString() == "")
                {
                    MessageBox.Show($"الرجاء إدخال كمية للدواء: {medName}",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int qu = int.Parse(Cart_dataGridView.Rows[i].Cells[4].Value.ToString());

                for (int j = 0; j < DataStorage.Medicines.Count; j++)
                {
                    if (DataStorage.Medicines[j].Name == medName)
                    {
                        if (qu > DataStorage.Medicines[j].Quantity)
                        {
                            MessageBox.Show($"الكمية المتوفرة من {medName} هي فقط: {DataStorage.Medicines[j].Quantity}",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (qu <= 0)
                        {
                            MessageBox.Show($"الرجاء إدخال كمية صحيحة للدواء: {medName}",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    }
                }
            }

            // بعد التحقق ننشئ الفاتورة
            Invoice invoice = new Invoice();

            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                string medName = Cart_dataGridView.Rows[i].Cells[0].Value.ToString();
                int qu = int.Parse(Cart_dataGridView.Rows[i].Cells[4].Value.ToString());

                for (int j = 0; j < DataStorage.Medicines.Count; j++)
                {
                    if (DataStorage.Medicines[j].Name == medName)
                    {
                        invoice.Medicines.Add(DataStorage.Medicines[j]);
                        invoice.Quantities.Add(qu);

                        // تخفيض المخزون
                        DataStorage.Medicines[j].Quantity -= qu;
                        break;
                    }
                }
            }

            invoice.CalculateTotal();

            // انشاء ملف PDF للفاتورة
            InvoiceGenerator.CreatePdfInvoice(invoice);

            DataStorage.Invoices.Add(invoice);

            InvoiceForm inv = new InvoiceForm(invoice);
            inv.ShowDialog();   

            MessageBox.Show($"تمت عملية الشراء بنجاح!\nالإجمالي: {invoice.Total} ",
                "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تصفير السلة
            Cart_dataGridView.Rows.Clear();

           
        }

      

        private void btnMG_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            management.Show();
            this.Close();
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            ExpiredMedicinesForm exp = new ExpiredMedicinesForm();
            exp.Show();
            this.Close();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (SelectedID_txt.Text == "")
            {
                MessageBox.Show("الرجاء إدخال رقم الدواء المراد شرائه!", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int SelectedID = int.Parse(SelectedID_txt.Text.Trim());
            int Qu = (int)Qu_NumUpDown.Value;

            // نبحث عن الدواء في القائمة
            Medicine SelectedMed = null;
            for (int i = 0; i < DataStorage.Medicines.Count; i++)
            {
                if (DataStorage.Medicines[i].Id == SelectedID)
                {
                    SelectedMed = DataStorage.Medicines[i];
                    break;
                }
            }

            // تحقق إذا الدواء موجود مسبقاً في السلة
            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                if (Cart_dataGridView.Rows[i].Cells[0].Value.ToString() == SelectedMed.Name)
                {
                    MessageBox.Show("الدواء موجود مسبقاً في السلة!", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // إضافة الدواء للسلة بكمية 0
            Cart_dataGridView.Rows.Add(SelectedMed.Name,SelectedMed.ScientificName,SelectedMed.Manufacturer,SelectedMed.Price, Qu);
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.Red;
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.FillColor = Color.DimGray;
        }

        private void SelectedID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

