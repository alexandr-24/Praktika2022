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
            double s1;
            double s2;

            Console.Write("Введите 1-ую сторону прямоугольника: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-ую сторону прямоугольника: ");
            s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(s1, s2);

            Console.WriteLine("Площадь прямоугольника: " + myRectangle.Area);
            Console.WriteLine("Периметр прямоугольника: " + myRectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
