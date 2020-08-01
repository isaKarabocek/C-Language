using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        public long calAge(System.DateTime StartDate, System.DateTime EndDate)
        {
            long age = 0;
            System.TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
            age = (long)(ts.Days / 365); 
            return age;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;

            label1.Text = calAge(start, end).ToString();
        }
    }
}
