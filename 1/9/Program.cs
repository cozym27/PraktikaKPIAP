using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    

    class Program
    {
        static void Main(string[] args)
        {
            double p; // процент увеличения пробега
            double distance = 10.0; // начальный пробег
            double totalDistance = distance; // суммарный пробег
            int days = 1; // количество дней

            Console.WriteLine("Введите процент увеличения пробега (0 < P < 50):");
            p = Convert.ToDouble(Console.ReadLine()); // считываем процент увеличения пробега

            while (totalDistance <= 200.0) // пока суммарный пробег не превысит 200 км
            {
                distance *= (1.0 + p / 100.0); // увеличиваем пробег на P процентов
                totalDistance += distance; // увеличиваем суммарный пробег на пробег за текущий день
                days++; // увеличиваем количество дней
            }

            Console.WriteLine($"Количество дней: {days}, суммарный пробег: {totalDistance} км");
            Console.ReadKey(); // ожидаем нажатия клавиши для завершения программы
        }
    }

}
