using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Rory Garner
//C00193506
//SoftWare Development
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int countPoint = 0;
        public Form1()
        {
            InitializeComponent();
            txtBxInput.Text = "0";
            label1.Text = "0";
            label2.Text = "+";
            label3.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("3"); // gives the number buttons a value 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBxInput.AppendText("0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = txtBxInput.Text; // puts the value from textbox1 to label1
            label2.Text = ("-");        // adds the  sign to label2
            txtBxInput.Clear();           // clears the value in textbox1
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = txtBxInput.Text; // puts the value from textbox1 to label1
            label2.Text = ("+");        // adds the  sign to label2
            txtBxInput.Clear();           // clears the value in textbox1
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = txtBxInput.Text; // puts the value from textbox1 to label1
            label2.Text = ("/");        // adds the  sign to label2
            txtBxInput.Clear();           // clears the value in textbox1

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = txtBxInput.Text; // puts the value from textbox1 to label1
            label2.Text = ("*");        // adds the  sign to label2
            txtBxInput.Clear();           // clears the value in textbox1
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String sign;
            Double number1 = 0;
            Double number2 = 0;
            Double result = 0;  // declaring variables
             
            label3.Text = txtBxInput.Text;   
            sign = label2.Text;
           
            number1 = double.Parse(label1.Text);
            number2 = double.Parse(label3.Text);
            result  = double.Parse(txtBxInput.Text); //converting to double

            switch (sign)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "/":
                    result = number1 / number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "%":
                    result = (number1 / number2) * 100;
                    break;
    //using a switch o choose what action 
                                       

            }
            txtBxInput.Text = Convert.ToString(result);   // prints the result to the textbox
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //txtBxInput.AppendText(".");
            if ( countPoint  < 1)
             {
                txtBxInput.Text = txtBxInput.Text + ".";
                countPoint++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtBxInput.Text = "0";   // clears the textbox
            label1.Text = (""); //empty the label
            label2.Text = (""); //empty the label // clears all the values 
            label3.Text = (""); //empty the label
            countPoint = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = txtBxInput.Text; // puts the value from textbox1 to label1
            label2.Text = ("%");        // adds the  sign to label2
            txtBxInput.Clear();           // clears the value in textbox1
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String deleted;
            String output;
            deleted = txtBxInput.Text;
            output = deleted.Remove(deleted.Length - 1);
            txtBxInput.Text = output;                       //reduces the length of the string by one 
            if (txtBxInput.Text == "")                      //curring off the last element
            {
                txtBxInput.Text = "0";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {   
        }
    }
}
