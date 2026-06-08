using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    public static class DataStorage
    {
        // كلاس لتخزين بيانات الأدوية والفواتير
        public static List<Medicine> Medicines = new List<Medicine>();
        public static List<Invoice> Invoices = new List<Invoice>();

        public static void StatringData() // ميثود البيانات الابتدائية للأدوية
        {
           Medicines.Add(new Medicine("Zerospasm","Alverine","Avevzor", 12000, 100, new DateTime(2025,1,1), 6214436071846));
           Medicines.Add(new Medicine("Revan", "Iprofen", "ProlinePharma", 4000, 65, new DateTime(2024, 10, 3), 6217290014417));
           Medicines.Add(new Medicine("Uraline", "Antispasmodic", "BahriPharma", 53500, 43, new DateTime(2026, 11, 4), 6211060020103));
           Medicines.Add(new Medicine("Flam-k", "DiclofenacPotassium", "DiamondPharma", 53500, 43, new DateTime(2028, 10, 4), 6210870075358));
           Medicines.Add(new Medicine("Retinoid", "Cream", "DiminaPharma", 17000, 13, new DateTime(2029, 7, 31), 6214327086423));
        }
    }
}
