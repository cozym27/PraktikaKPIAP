using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2зад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double result = Math.Log((Math.Sin(Math.Pow(a, 2)) + Math.Cos(b)) / Math.Sqrt(1 + (Math.E / ((Math.Pow(a, 3)) + 3.4 * b))));

            textBox4.Text = "Результат: " + result.ToString();
        }

        
    }
}
