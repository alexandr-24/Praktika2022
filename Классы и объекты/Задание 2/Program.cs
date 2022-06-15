using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0, "Точка 1");
            Point p2 = new Point(0, 5, "Точка 2");
            Point p3 = new Point(5, 5, "Точка 3");
            Point p4 = new Point(5, 0, "Точка 4");
            Figure figure = new Figure("Квадрат", p1, p2, p3, p4);

            Console.WriteLine(figure.Name);
            Console.WriteLine("Периметр: " + figure.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}
