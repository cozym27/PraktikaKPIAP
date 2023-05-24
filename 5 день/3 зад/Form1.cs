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

namespace _3_зад
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
            int n1 = int.Parse(textBox3.Text);
            int n2 = int.Parse(textBox4.Text);
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            string result = MergeStrings(n1, n2, s1, s2);

            textBox5.Text = result;
        }

        private string MergeStrings(int n1, int n2, string s1, string s2)
        {
            string mergedString = "";

            if (n1 < 0 || n2 < 0 || n1 > s1.Length || n2 > s2.Length)
            {
                return "Ошибка: некорректные значения";
            }

            string firstPart = s1.Substring(0, n1);
            string secondPart = s2.Substring(s2.Length - n2, n2);

            mergedString = firstPart + secondPart;

            return mergedString;
        }
    }
}
