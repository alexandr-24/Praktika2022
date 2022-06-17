using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Поезд {0}:", i + 1);
                Console.Write("Номер: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Пункт назначения: ");
                string punkt = Console.ReadLine();
                Console.Write("Время отправления: ");
                string time = Console.ReadLine();
                Console.WriteLine();

                trains[i] = new Train(punkt, n, time);
            }

            // записи должны быть упорядочены по номерам поездов
            Train temp;
            for (int i = 0; i < trains.Length - 1; i++)
            {
                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].nomer > trains[j].nomer)
                    {
                        temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }

            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].GetInfo();
                Console.WriteLine();
            }

            Console.Write("Поиск поезда:\nНомер поезда: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].nomer == k)
                {
                    trains[i].GetInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
