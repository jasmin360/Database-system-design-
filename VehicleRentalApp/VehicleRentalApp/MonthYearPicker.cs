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
            // block the day calendar from appearing — only month/year via up/down
            if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
            base.WndProc(ref m);
        }
    }
}
