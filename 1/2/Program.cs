using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, temp;

            Console.Write("Введите значение a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Введите значение c: ");
            c = double.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = c;
            c = temp;

            Console.WriteLine("Новое значение a: {0}", a);
            Console.WriteLine("Новое значение b: {0}", b);
            Console.WriteLine("Новое значение c: {0}", c);

            Console.ReadKey();
        }
    }

}
