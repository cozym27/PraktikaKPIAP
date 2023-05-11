using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_день
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text); // считываем значение N из текстового поля
            int[] arr = new int[N]; // создаем массив размера N
            for (int i = 0; i < N; i++)
            {
                arr[i] = (int)Math.Pow(2, i + 1); // заполняем массив степенями двойки от первой до N-й
            }
            // выводим массив в текстовое поле
            textBox2.Text = string.Join(", ", arr);
        }
    }
}
