using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._21_seperating
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDisp_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox_take_int.Text);
            b = Convert.ToInt32(textBox_divider.Text);
            textBoxDisplay1.Text = ("integer part of the number: " + findQuotient(a, b));
            textBoxDisplay2.Text = ("remainder part of the number: " + findRemainder(a, b));
            Display(a); //Consol için yazdığım kod, form app'e geçince 3 basamaklı sayıları ayıramıyor _?
        }
        public void Display(int num)
        {
            int divisor = 10;

            if (num >= 10)
            {
                Display(num / 10);
            }
            textBoxDividedNum.Text =Convert.ToString (findQuotient(num, divisor))+ " " +
                Convert.ToString( findRemainder(num, divisor));
        }
        static int findRemainder(int num, int dividedBy)
        {
            return num % dividedBy;
        }
        static int findQuotient(int num, int dividedBy)
        {
            return num / dividedBy;
        }
    }
}

