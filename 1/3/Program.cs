using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, ton;

            Console.Write("Введите массу в килограммах: ");
            m = double.Parse(Console.ReadLine());

            ton = m / 1000;

            Console.WriteLine("Количество полных тонн: {0}", (int)ton);

            Console.ReadKey();
        }
    }


}
