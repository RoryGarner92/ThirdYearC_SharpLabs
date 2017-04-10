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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double cel = 0.0;
            Double result = 0.0;// declaring variables 

            cel = double.Parse(textBox1.Text); //value to number
            result = ((cel * 9 / 5) + 32);// calculation
            label1.Text = result.ToString();// answer to string 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
