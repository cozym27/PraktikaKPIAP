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

            private void buttonCalculate_Click(object sender, EventArgs e)
            {
                double x, v, sum;
                int n;
                const double a = 0.001;

                if (!double.TryParse(textBoxX.Text, out x))
                {
                    MessageBox.Show("Введите корректное значение x");
                    return;
                }

                v = x;
                sum = 0;
                n = 1;

                while (Math.Abs(v) > a)
                {
                    sum += v;
                    n++;
                    v *= -x * n / (n - 1);
                }

                textBoxResult.Text = sum.ToString();
            }
        }
    

}
