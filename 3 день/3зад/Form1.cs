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


namespace _3зад
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
            double a, b, c, x, dx, fx;
            int ac, bc, cc;

            if (!double.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show("Некорректное значение a", "Ошибка");
                return;
            }

            if (!double.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Некорректное значение b", "Ошибка");
                return;
            }

            if (!double.TryParse(textBoxC.Text, out c))
            {
                MessageBox.Show("Некорректное значение c", "Ошибка");
                return;
            }

            if (!double.TryParse(textBoxXFrom.Text, out x))
            {
                MessageBox.Show("Некорректное значение Xнач.", "Ошибка");
                return;
            }

            if (!double.TryParse(textBoxXTo.Text, out double xTo))
            {
                MessageBox.Show("Некорректное значение Xкон.", "Ошибка");
                return;
            }

            if (!double.TryParse(textBoxStep.Text, out dx))
            {
                MessageBox.Show("Некорректное значение dX", "Ошибка");
                return;
            }

            dataGridViewResults.Rows.Clear();

            for (double i = x; i <= xTo; i += dx)
            {
                ac = (int)Math.Truncate(a);
                bc = (int)Math.Truncate(b);
                cc = (int)Math.Truncate(c);

                if ((ac & bc) != 0 || (bc & cc) != 0)
                {
                    fx = 1.0 / (a * i) - b;
                }
                else if (i + 5 > 0 && c != 0)
                {
                    fx = (i - a) / i;
                }
                else
                {
                    fx = 10 * i / (c - 4);
                }

                if (Math.Truncate(fx) == fx)
                {
                    dataGridViewResults.Rows.Add(i, (int)fx);
                }
                else
                {
                    dataGridViewResults.Rows.Add(i, fx);
                }
            }
        }

      
    }
}

