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

namespace _2зад
{
    

    
        public partial class Form1 : Form
        {
            private const int NumCircles = 10;
            private readonly int[] _circleRadii = { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 };
            private readonly Brush[] _circleBrushes = { Brushes.White, Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Indigo, Brushes.Violet, Brushes.Gray, Brushes.Black };

            public Form1()
            {
                InitializeComponent();
                pictureBoxCanvas.Paint += pictureBoxCanvas_Paint;
            }

            private void buttonScore_Click_1(object sender, EventArgs e)
            {
                double x, y;
                if (!double.TryParse(textBoxX.Text, out x))
                {
                    MessageBox.Show("Введите корректное значение координаты x");
                    return;
                }

                if (!double.TryParse(textBoxY.Text, out y))
                {
                    MessageBox.Show("Введите корректное значение координаты y");
                    return;
                }

                int score = GetScore(x, y);
                MessageBox.Show($"Очков: {score}");
            }

            private int GetScore(double x, double y)
            {
                double r = Math.Sqrt(x * x + y * y);
                if (r > _circleRadii[NumCircles - 1]) // точка вне мишени
                {
                    return 0;
                }

                for (int i = 0; i < NumCircles; i++)
                {
                    if (r <= _circleRadii[i]) // точка попала в круг
                    {
                        return NumCircles - i; // начисляем очки в зависимости от радиуса круга
                    }
                }

                return 0; // точка попала в молоко, очков не начисляется
            }

            private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
            {
                // рисуем мишень на pictureBox
                for (int i = 0; i < NumCircles; i++)
                {
                    int diameter = _circleRadii[i] * 2;
                    int x = pictureBoxCanvas.Width / 2 - _circleRadii[i];
                    int y = pictureBoxCanvas.Height / 2 - _circleRadii[i];
                    e.Graphics.FillEllipse(_circleBrushes[i], x, y, diameter, diameter);
                }
            }
        }
    

}
