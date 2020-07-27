using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitl_1._0
{
    public partial class Form1 : Form
    {
        Info[] information = new Info[100];
        int a = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
           information[a] = new Info(textBoxName.Text, textBoxSurname.Text,
                Convert.ToInt32(textBoxAge.Text), 
                comboBoxDisease.GetItemText(comboBoxDisease.SelectedItem),
                comboBoxInsurance.GetItemText(comboBoxInsurance.SelectedItem));
          
            listBoxDisplay.Items.Add(information[a]);

        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            /*string lastWord = listBoxDisplay.GetItemText(listBoxDisplay.SelectedItem);
            string word = lastWord.Substring(lastWord.LastIndexOf(" ") + 1);

            if (word == "YTU")
                textBoxBill.Text = "40% discount = 60$ ";
            if (word == "SGK")
                textBoxBill.Text = "20% discount = 80$";
            if (word == "Special")
                textBoxBill.Text = "10% discount = 90$";
            if (word == "None")
                textBoxBill.Text = "No insurance = 100$";*/

             labelTotal.Text = "Total:" + "100$";
             labelPname.Text = "Name:    " + information[a].name;
             labelPsur.Text = "Surname:  " + information[a].surname;

             if (information[a].insureance == "YTU")
             {
                 textBoxBill.Text = "40% discount = 60$ ";
                 labelDisc.Text = "Discount:   40%";
                 labelAmount.Text = "Amount:   60$";
             }
             else if (information[a].insureance == "SGK")
             {
                 textBoxBill.Text = "20% discount = 80$";
                 labelDisc.Text = "Discount:   20%";
                 labelAmount.Text = "Amount:   80$";
             }
             else if (information[a].insureance == "Special")
             {
                 textBoxBill.Text = "10% discount = 90$";
                 labelDisc.Text = "Discount:   10%";
                 labelAmount.Text = "Amount:   90$";
             }
             else
             {
                 textBoxBill.Text = "No insurance = 100$";
                 labelDisc.Text = "Discount:   Patient has no insurance";
                 labelAmount.Text = "Amount:   100$";
             }
    
        }

    }
}
