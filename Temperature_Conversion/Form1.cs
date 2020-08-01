using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._22_temperature_conversion
{
    public partial class Form1 : Form
    {
        double f, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(textBoxTempC.Text);
            textBoxTempC.Text = Convert.ToString (returnCelcius(c));
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBoxTemF.Text);
            textBoxTemF.Text = Convert.ToString(returnFahreneit(f));
        }

        static double returnCelcius(double f)
        {
            return (5 * (f - 32)) / 9;
        }

        static double returnFahreneit(double c)
        {
            return (9 * c / 5) + 32;
        }
    }
}
