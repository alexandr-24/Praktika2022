using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Figure
    {
        private List<Point> Points = new List<Point>(); // Точки
        private string name; // Название фигуры

        // Конструктор
        public Figure(string Name, Point P1, Point P2, Point P3)
        {
            name = Name;
            Points.Add(P1);
            Points.Add(P2);
            Points.Add(P3);
        }
        public Figure(string Name, Point P1, Point P2, Point P3, Point P4)
        {
            name = Name;
            Points.Add(P1);
            Points.Add(P2);
            Points.Add(P3);
            Points.Add(P4);
        }
        public Figure(string Name, Point P1, Point P2, Point P3, Point P4, Point P5)
        {
            name = Name;
            Points.Add(P1);
            Points.Add(P2);
            Points.Add(P3);
            Points.Add(P4);
            Points.Add(P5);
        }

        public string Name
        {
            get { return name; }
        }

        public double LengthSide(Point A, Point B) // √(xb - xa)2 + (yb - ya)2
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double p = 0;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                p += LengthSide(Points[i], Points[i + 1]);
            }
            p += LengthSide(Points[Points.Count - 1], Points[0]);
            return p;
        }
    }
}
