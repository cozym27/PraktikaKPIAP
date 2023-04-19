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

            private void button1_Click(object sender, EventArgs e)
            {
                double a, b, expResult, eValue;
                double.TryParse(textBox1.Text, out a);
                double.TryParse(textBox2.Text, out b);
                double.TryParse(textBox3.Text, out eValue);

                expResult = Math.Log((Math.Sin(Math.Pow(a, 2)) + Math.Cos(b)) / Math.Sqrt(1 + (eValue / (Math.Pow(a, 3) + 3.4 * b))));

                label1.Text = "ln((sin a^2 +cos b)/(√1+(e/((a^3) + 3,4*b)))) = " + expResult.ToString();
            }
        }
    

}
