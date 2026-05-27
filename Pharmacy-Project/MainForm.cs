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
       
           

            Cart_dataGridView.AutoGenerateColumns = false;
            Cart_dataGridView.AllowUserToAddRows = false;
            Cart_dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Na";
            nameCol.ReadOnly = true;

            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.HeaderText = "Pr";
            priceCol.ReadOnly = true;

            DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
            qtyCol.HeaderText = "Qt";
            qtyCol.ReadOnly = false;

            Cart_dataGridView.Columns.Add(nameCol);
            Cart_dataGridView.Columns.Add(priceCol);
            Cart_dataGridView.Columns.Add(qtyCol);
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

            Show_dataGridView.DataSource = null;
            Show_dataGridView.DataSource = result;
        }

        private void Show_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.RowIndex < 0) return;

            // نقرأ الاسم من الصف المضغوط
            string medName = Show_dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();

            // نبحث عن الدواء في القائمة
            Medicine selectedMed = null;
            for (int i = 0; i < DataStorage.Medicines.Count; i++)
            {
                if (DataStorage.Medicines[i].Name == medName)
                {
                    selectedMed = DataStorage.Medicines[i];
                    break;
                }
            }

            // تحقق إذا الدواء موجود مسبقاً في السلة
            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                if (Cart_dataGridView.Rows[i].Cells[0].Value.ToString() == selectedMed.Name)
                {
                    MessageBox.Show("الدواء موجود مسبقاً في السلة!", "تنبيه",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // إضافة الدواء للسلة بكمية 0
            Cart_dataGridView.Rows.Add(selectedMed.Name, selectedMed.Price, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            // التحقق من أن السلة مش فارغة
            if (Cart_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("السلة فارغة!", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من الكميات أولاً قبل أي عملية
            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                string medName = Cart_dataGridView.Rows[i].Cells[0].Value.ToString();
                if (Cart_dataGridView.Rows[i].Cells[2].Value == null || Cart_dataGridView.Rows[i].Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show($"الرجاء إدخال كمية للدواء: {medName}",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int qty = int.Parse(Cart_dataGridView.Rows[i].Cells[2].Value.ToString());

                for (int j = 0; j < DataStorage.Medicines.Count; j++)
                {
                    if (DataStorage.Medicines[j].Name == medName)
                    {
                        if (qty > DataStorage.Medicines[j].Quantity)
                        {
                            MessageBox.Show($"الكمية المتوفرة من {medName} هي فقط: {DataStorage.Medicines[j].Quantity}",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // نوقف العملية كلها
                        }
                        if (qty <= 0)
                        {
                            MessageBox.Show($"الرجاء إدخال كمية صحيحة للدواء: {medName}",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    }
                }
            }

            // بعد التحقق، ننشئ الفاتورة
            Invoice invoice = new Invoice();

            for (int i = 0; i < Cart_dataGridView.Rows.Count; i++)
            {
                string medName = Cart_dataGridView.Rows[i].Cells[0].Value.ToString();
                int qty = int.Parse(Cart_dataGridView.Rows[i].Cells[2].Value.ToString());

                for (int j = 0; j < DataStorage.Medicines.Count; j++)
                {
                    if (DataStorage.Medicines[j].Name == medName)
                    {
                        invoice.Medicines.Add(DataStorage.Medicines[j]);
                        invoice.Quantities.Add(qty);

                        // تخفيض المخزون
                        DataStorage.Medicines[j].Quantity -= qty;
                        break;
                    }
                }
            }

            invoice.CalculateTotal();
            DataStorage.Invoices.Add(invoice);

            MessageBox.Show($"تمت عملية الشراء بنجاح!\nالإجمالي: {invoice.Total} ل.س",
                "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تصفير السلة
            Cart_dataGridView.Rows.Clear();

            Helper.Refresh(Show_dataGridView);
        }
    }
    
    
}

