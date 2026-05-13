using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    public class Invoice
    {
        // كلاس الفواتير
        public List<Medicine> Medicines { get; set; }
        public List<int> Quantities { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }

        public Invoice()
        {
            Medicines = new List<Medicine>();
            Quantities = new List<int>();
            Date = DateTime.Now;
            Total = 0;
        }

        public void CalculateTotal()
        {
            Total = 0;
            for (int i = 0; i < Medicines.Count; i++)
            {
                Total += Medicines[i].Price * Quantities[i];
            }
        }
    }
}
