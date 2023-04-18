using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число A:");
            int a = Convert.ToInt32(Console.ReadLine()); // считываем число A
            Console.WriteLine("Введите целое число B (B > A):");
            int b = Convert.ToInt32(Console.ReadLine()); // считываем число B

            int count = 0; // переменная для хранения количества чисел

            for (int i = a; i <= b; i++) // перебираем все числа от A до B
            {
                Console.WriteLine(i); // выводим число i
                count++; // увеличиваем счетчик чисел
            }

            Console.WriteLine($"Количество чисел: {count}"); // выводим количество чисел
            Console.ReadKey(); // ожидаем нажатия клавиши для завершения программы
        }
    }

}
