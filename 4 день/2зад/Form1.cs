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
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FindIndex_Click(object sender, EventArgs e)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 0, 9, 8 };
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A[0] && A[i] < A[A.Length - 1])
                {
                    index = i;
                }
            }

            if (index == 0)
            {
                MessageBox.Show("0");
            }
            else
            {
                MessageBox.Show(index.ToString());
            }
        }



    }
}
