using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalApp
{
    public class MonthYearPicker : System.Windows.Forms.DateTimePicker
    {
        public MonthYearPicker()
        {
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomFormat = "MMMM yyyy";
            this.ShowUpDown = true;
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 0x204) return; 
            base.WndProc(ref m);
        }
    }
}
