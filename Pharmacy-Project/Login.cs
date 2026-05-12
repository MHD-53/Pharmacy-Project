using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Project
{
    internal class Login
    {
        public static bool CheckUser (string username, string password)
        {
            const string Username  = "admin";
            const string Password = "123";
            if (username == Username && password == Password)
            {
                return true;
            }


            else { 
                return false;
                 }
        }
        
    }
}
