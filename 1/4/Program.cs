using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n, minutes;

            Console.Write("Введите количество секунд: ");
            n = int.Parse(Console.ReadLine());

            minutes = n / 60;

            Console.WriteLine("Количество полных минут: {0}", minutes);

            Console.ReadKey();
        }
    }

}
