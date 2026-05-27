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

        public static void OriginalMedicines() // ميثود البيانات الابتدائية للأدوية
        {
           Medicines.Add(new Medicine("Panadol","paracetamol","TST", 10.0, 100, new DateTime(2026,12,10), 1));
           Medicines.Add(new Medicine("Sinadol", "par4", "gg", 5.0, 600, new DateTime(2024, 10, 3), 2));
           Medicines.Add(new Medicine("OOanadol", "par", "aa", 8.0, 600, new DateTime(222, 10, 3), 3));
            
        }
    }
}
