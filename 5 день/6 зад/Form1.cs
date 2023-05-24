using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_зад
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
            string input = textBox1.Text;
            string result = RemoveEvenWords(input);

            textBox2.Text = result;
        }

        private string RemoveEvenWords(string input)
        {
            string[] words = input.Split(' ');
            string[] oddWords = words.Where((w, index) => index % 2 == 0).ToArray();
            string result = string.Join(" ", oddWords);

            return result;
        }
    }
}
