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

            private void buttonCalculate_Click(object sender, EventArgs e)
            {
                int m, n;
                if (!int.TryParse(textBoxM.Text, out m))
                {
                    MessageBox.Show("Введите корректное значение m");
                    return;
                }

                if (!int.TryParse(textBoxN.Text, out n))
                {
                    MessageBox.Show("Введите корректное значение n");
                    return;
                }

                int gcd = GCD(m, n);
                int lcm = m * n / gcd;

                textBoxResult.Text = lcm.ToString();
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
        }
    

}
