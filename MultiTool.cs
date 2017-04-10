using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        String currencySelected1 = ""; 
        String currencySelected2 = ""; // declaring the variables
       
        public Form1()
        {
            InitializeComponent();
            cmbBxCurrentCurrency.SelectedIndex = 0;
            cmbBxNewCurrency.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double inputVal = 0.0;
            Double answer = 0.0; // inital value gets zero

            //**********************************************************

            try
            {
                // Code to try goes here.
                inputVal = Double.Parse(txtBxInput.Text);
            }
            catch (System.FormatException ex)
            {
                txtBxInput.Text = " Keep it Neumerical"; // the non number error fix
            }
            
         

            if (currencySelected1 == "Euro"&& currencySelected2 == "Pound")
            {
                answer = inputVal * .86;
                lblResult.Text = answer.ToString();
            }
            else if (currencySelected1 == "Euro" && currencySelected2 == "USD")
            {
                answer = inputVal * 1.12;
                lblResult.Text = answer.ToString();
            }
            else if (currencySelected1 == "Euro" && currencySelected2 == "Euro")
            {
                answer = inputVal ;
                lblResult.Text = answer.ToString();
            }

            if (currencySelected1 == "Pound" && currencySelected2 == "Euro")
            {
                answer = inputVal * 1.17;
                lblResult.Text = answer.ToString();
            }
            else if (currencySelected1 == "Pound" && currencySelected2 == "USD")
            {
                answer = inputVal * 1.30;
                lblResult.Text = answer.ToString();
            }
            else if (currencySelected1 == "Pound" && currencySelected2 == "Pound")
            {
                answer = inputVal;
                lblResult.Text = answer.ToString();
            }

            if (currencySelected1 == "USD" && currencySelected2 == "Pound")
            {
                answer = inputVal * .77;
                lblResult.Text = answer.ToString();
            }
            else if (currencySelected1 == "USD" && currencySelected2 == "Euro")
            {
                answer = inputVal * .90;
                lblResult.Text = answer.ToString();
            }
             else if (currencySelected1 == "USD" && currencySelected2 == "USD")
            {
                answer = inputVal;
                lblResult.Text = answer.ToString();   //different options for conversion 
            }                                         // answer put to a string 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencySelected1 = cmbBxCurrentCurrency.SelectedItem.ToString(); 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencySelected2 = cmbBxNewCurrency.SelectedItem.ToString();
        }
                                                                              //drops boxs getting values 
        private void button2_Click(object sender, EventArgs e)
        {
           txtBxInput.Clear();
           txtBxInput.Text  = lblResult.Text;                                  // reuse button sends the answer from
        }                                                                      // result label after the input is cleared

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
