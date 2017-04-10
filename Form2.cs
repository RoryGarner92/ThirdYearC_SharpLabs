using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double feet = 0.0;
            Double result = 0.0;
            Double inches = 12;     //declaring the variables

            feet = double.Parse(textBox1.Text); // converts textbox val to a nuber
            result = feet / inches;
            label1.Text = result.ToString(); // Outputs the the result to a label
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
