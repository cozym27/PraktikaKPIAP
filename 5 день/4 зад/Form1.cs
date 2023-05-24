using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_зад
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
            string result = RemoveShortestWord(input);

            textBox2.Text = result;
        }

        private string RemoveShortestWord(string input)
        {
            // Разделение строки на слова по запятой и точке
            string[] words = input.Split(new char[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // Поиск длины самого короткого слова
            int minLength = words.Min(w => w.Length);

            // Удаление всех самых коротких слов
            words = words.Where(w => w.Length != minLength).ToArray();

            // Сборка строки снова с использованием запятых и точки
            string result = string.Join(", ", words) + ".";

            return result;
        }
    }
}
