using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Form1 : Form
    {
        double firstNum;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            display.Text += button.Text;
            label1.Text = button.Text;
        }

        private void btn_plus(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(display.Text);
            display.Text = " ";
            Operation = "+";
        }

        private void btn_Subs(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(display.Text);
            display.Text = " ";
            Operation = "-";
        }

        private void btn_Mul(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(display.Text);
            display.Text = " ";
            Operation = "*";
        }

        private void btn_Dived(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(display.Text);
            display.Text = " ";
            Operation = "/";
        }

        private void btn_equal(object sender, EventArgs e)
        {
            double secondNum;
            double result;

            secondNum = Convert.ToDouble(display.Text);

            if(Operation == "+")
            {
                result = (firstNum + secondNum);
                display.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (Operation == "-")
            {
                result = (firstNum - secondNum);
                display.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (Operation == "*")
            {
                result = (firstNum * secondNum);
                display.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (Operation == "/")
            {
                if(secondNum == 0)
                {
                    display.Text = "can not divide by zero";
                }
                else
                {
                    result = (firstNum / secondNum);
                    display.Text = Convert.ToString(result);
                    firstNum = result;
                }
             
            }
            
        }

        private void btn_clear(object sender, EventArgs e)
        {
            display.Clear();
        }
    }
}
