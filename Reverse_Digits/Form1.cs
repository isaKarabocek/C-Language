using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._26_reverse_digits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(textBoxRev.Text);
            int Reverse = 0;

            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            textBoxRev.Text = Convert.ToString(Reverse);

        }
    }
}
