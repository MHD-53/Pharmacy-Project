using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    // كلاس الأدوية
    public class Medicine
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string Manufactuere { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Medicine(string name, string scientificName, string manufactuere, double price, int quantity, DateTime expiryDate)
        {
            Name = name;
            ScientificName = scientificName;
            Manufactuere = manufactuere;
            Price = price;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}
