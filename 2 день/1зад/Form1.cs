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
        private void button1_Click_1(object sender, EventArgs e)
        double x = double.Parse(textBox1.Text);
        double y = double.Parse(textBox2.Text);
        double z = double.Parse(textBox3.Text);
        double u = -55.6848;

        double result = ((Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1 / 3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z), 2 * x + 1);

        textBox4.Text = "Результат: " + result.ToString();
        textBox5.Text = "Правильный ответ: " + u.ToString();
            
    }
}
