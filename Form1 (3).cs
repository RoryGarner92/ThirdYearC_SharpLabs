using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Rory Garner
//Class:CW_KCSOF_D
//Type C#
//C00193506
//Multi-tool Linked through menu

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inchToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 inchToFoot = new Form2();     // opens the newForm
            inchToFoot.Show();
        }

        private void poundToEuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 PoundToEuro = new Form3();
            PoundToEuro.Show();
        }

        private void celToFahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 CelToFah = new Form4();
            CelToFah.Show();
        }

        private void fahToCelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 FahToCel = new Form5();
            FahToCel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
