using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите достоинство карты (6-14):");
            int n = Convert.ToInt32(Console.ReadLine()); // считываем достоинство карты
            Console.WriteLine("Введите масть карты (1-4):");
            int m = Convert.ToInt32(Console.ReadLine()); // считываем масть карты

            string rank = ""; // переменная для хранения названия достоинства карты

            switch (n)
            {
                case 6:
                    rank = "шестерка";
                    break;
                case 7:
                    rank = "семерка";
                    break;
                case 8:
                    rank = "восьмерка";
                    break;
                case 9:
                    rank = "девятка";
                    break;
                case 10:
                    rank = "десятка";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    Console.WriteLine("Ошибка: введено некорректное значение достоинства карты.");
                    Console.ReadKey();
                    return;
            }

            string suit = ""; // переменная для хранения названия масти карты

            switch (m)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "червей";
                    break;
                default:
                    Console.WriteLine("Ошибка: введено некорректное значение масти карты.");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine($"Название карты: {rank} {suit}"); // выводим результат
            Console.ReadKey(); // ожидаем нажатия клавиши для завершения программы
        }
    }

}
