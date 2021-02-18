using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GriSHIN
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static int ModPow(int x, int y, int z) => y == 0 ? 1 : (x * ModPow(x, y - 1, z)) % z;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox2.Text), q = Convert.ToInt32(textBox1.Text), l = 7, d = 7;
            int n, c = 0, m, r = 0;
            string s;
            n = p * q;
            s = textBox3.Text;
            m = Convert.ToInt32(s);
            textBox6.Text = l.ToString() + ", " + n.ToString();
            textBox7.Text = d.ToString() + ", " + n.ToString();
            if (m >= 0 && m < (n - 1))
            {
                c = ModPow(m, l, n);
                textBox4.Text = c.ToString();
                r = ModPow(c, d, n);
                textBox5.Text = r.ToString();
            }
            else MessageBox.Show("Напишите число поменьше");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


