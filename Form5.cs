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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double result = 0.0;
            Double fah = 0.0;// declaring the variables

            fah = double.Parse(textBox1.Text);//text to number
            result = ((fah-32)*5/9);// calculation 
            label1.Text = result.ToString();// answer back to string
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
