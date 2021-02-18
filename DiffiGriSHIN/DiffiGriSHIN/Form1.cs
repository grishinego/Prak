using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffiGriSHIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = Convert.ToInt32(textBox1.Text);
            int p = Convert.ToInt32(textBox2.Text);
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            double aa = Math.Pow(g, a) % p;
            double bb = Math.Pow(g, b) % p;
            double ka = Math.Pow(bb, a) % p;
            double kb = Math.Pow(aa, b) % p;
            textBox5.Text = ka.ToString();
            textBox6.Text = kb.ToString();
        }
    }
}
