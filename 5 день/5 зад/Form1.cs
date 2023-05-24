using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_зад
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
            string[] words = input.Split(' ');

            string[] oddLengthWords = GetOddLengthWords(words);
            int count = oddLengthWords.Length;

            string result = string.Join(", ", oddLengthWords);

            textBox2.Text = $"Слова: {result}\n; Количество: {count}";
        }

        private string[] GetOddLengthWords(string[] words)
        {
            var oddLengthWords = words.Where(w => w.Length % 2 != 0).ToArray();
            return oddLengthWords;
        }
    }
}
