using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    static class TextPrinter
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(stroka, Console.ForegroundColor);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("Выберете цвет (0 - белый, 1 - красный, 2 - зеленый, 3 - синий): ");
            int color = Convert.ToInt32(Console.ReadLine());

            TextPrinter.Print(stroka, color);

            Console.ReadKey();
        }
    }
}
