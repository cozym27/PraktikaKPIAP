using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:"); // выводим сообщение пользователю
            int num = Convert.ToInt32(Console.ReadLine()); // считываем число, введенное пользователем

            if (num > 0)
            {
                num += 1; // прибавляем 1, если число положительное
            }
            else
            {
                num -= 2; // вычитаем 2, если число отрицательное или равно 0
            }

            Console.WriteLine($"Результат: {num}"); // выводим результат
            Console.ReadKey(); // ожидаем нажатия клавиши для завершения программы
        }
    }


}
