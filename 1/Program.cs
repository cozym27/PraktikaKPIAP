using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s, p;

            Console.Write("Введите сторону a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону b: ");
            b = double.Parse(Console.ReadLine());

            s = a * b;
            p = 2 * (a + b);

            Console.WriteLine("Площадь прямоугольника: {0}", s);
            Console.WriteLine("Периметр прямоугольника: {0}", p);

            Console.ReadKey();
        }
    }

}
