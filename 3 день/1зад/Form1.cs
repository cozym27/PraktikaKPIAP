using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1зад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            if (!int.TryParse(textBox1.Text, out m))
            {
                MessageBox.Show("Введите корректное значение m");
                return;
            }
            if (!int.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите корректное значение n");
                return;
            }
            int gcd = GCD(m, n);
            int lcm = m * n / gcd;
            textBox3.Text = lcm.ToString();
        }
    }
}
