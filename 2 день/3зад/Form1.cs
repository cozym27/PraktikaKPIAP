using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3зад
{
  
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                double x1 = 0.1;
                double x2 = 0.77;
                double x3 = -0.9;
                double a = 0.001;
                double sum1 = 1;
                double sum2 = 1;
                double sum3 = 1;
                int n = 1;

                // Вычисление для x1
                while (Math.Abs(sum1) >= a)
                {
                    double term = Math.Pow(-1, n - 1) * n * Math.Pow(x1, n - 1);
                    sum1 += term;
                    n++;
                }
                textBox1.Text += "F(" + x1 + ") = " + sum1.ToString() + Environment.NewLine;

                // Вычисление для x2
                n = 1;
                while (Math.Abs(sum2) >= a)
                {
                    double term = Math.Pow(-1, n - 1) * n * Math.Pow(x2, n - 1);
                    sum2 += term;
                    n++;
                }
                textBox2.Text += "F(" + x2 + ") = " + sum2.ToString() + Environment.NewLine;

                // Вычисление для x3
                n = 1;
                while (Math.Abs(sum3) >= a)
                {
                    double term = Math.Pow(-1, n - 1) * n * Math.Pow(x3, n - 1);
                    sum3 += term;
                    n++;
                }
                textBox3.Text += "F(" + x3 + ") = " + sum3.ToString() + Environment.NewLine;
            }
        }
}
