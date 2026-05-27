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
    public partial class InvoiceForm : Form
    {
        private Invoice invoice;
        public InvoiceForm(Invoice inv)
        {
            InitializeComponent();
            this.invoice = inv;

            
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

           
                Invoice_dataGridView.AutoGenerateColumns = false;
                Invoice_dataGridView.AllowUserToAddRows = false;
                Invoice_dataGridView.Columns.Clear();

                DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
                nameCol.HeaderText = "اسم الدواء";
                nameCol.ReadOnly = true;

                DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
                priceCol.HeaderText = "السعر";
                priceCol.ReadOnly = true;

                DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
                qtyCol.HeaderText = "الكمية";
                qtyCol.ReadOnly = true;

                DataGridViewTextBoxColumn subtotalCol = new DataGridViewTextBoxColumn();
                subtotalCol.HeaderText = "المجموع";
                subtotalCol.ReadOnly = true;

                Invoice_dataGridView.Columns.Add(nameCol);
                Invoice_dataGridView.Columns.Add(priceCol);
                Invoice_dataGridView.Columns.Add(qtyCol);
                Invoice_dataGridView.Columns.Add(subtotalCol);

                for (int i = 0; i < invoice.Medicines.Count; i++)
                {
                    double subtotal = invoice.Medicines[i].Price * invoice.Quantities[i];
                    Invoice_dataGridView.Rows.Add(
                        invoice.Medicines[i].Name,
                        invoice.Medicines[i].Price,
                        invoice.Quantities[i],
                        subtotal
                    );
                }

                lblTotal.Text = $"الإجمالي: {invoice.Total} ل.س";
                lblDate.Text = $"التاريخ: {invoice.Date}";
            }
        }

    
    
}
