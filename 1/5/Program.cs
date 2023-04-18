using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -4.5;
            double y = 0.75 * Math.Pow(10, -4);
            double z = 0.845 * Math.Pow(10, 2);
            double u = -55.6848;

            double result = ((Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1/3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z), 2 * x + 1);

            Console.WriteLine("Результат: " + result);
            Console.WriteLine("Правильный ответ: " + u);
            Console.ReadKey();
        }
    }

}
