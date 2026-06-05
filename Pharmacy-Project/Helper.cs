using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Pharmacy_Project
{
    internal class Helper
    {
        //public static void ClearTextBoxes(Control control)
        //{
        //    foreach (Control c in control.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            ((TextBox)c).Clear();
        //        }
        //        else
        //        {
        //            ClearTextBoxes(c);
        //        }
        //    }
        //}

        public static void Refresh(DataGridView gd)
        {
            gd.DataSource = null;
            gd.DataSource = DataStorage.Medicines;
        }
        
        
    }
}
