using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_зад
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
            string filePath = textBox1.Text;
            string fileName = ExtractFileName(filePath);

            textBox2.Text = fileName;
        }

        private string ExtractFileName(string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            return fileName;
        }
    }
}
