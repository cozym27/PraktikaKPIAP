using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1зад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = -4.5;
            double y = 0.75 * Math.Pow(10, -4);
            double z = 0.845 * Math.Pow(10, 2);
            double u = -55.6848;

            double result = ((Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z), 2 * x + 1);
            textBox1.Text = "x: " + x.ToString();
            textBox2.Text = "y: " + y.ToString();
            textBox3.Text = "z: " + z.ToString();
            textBox4.Text = "Результат: " + result.ToString();
            textBox5.Text = "Правильный ответ: " + u.ToString();
        }

       
    }
}