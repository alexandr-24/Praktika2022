using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Rectangle
    {
        private double side1; // 1-ая сторона прямоугольника
        private double side2; // 2-ая сторона прямоугольника

        /// <summary>
        /// Констуктор прямоугольника
        /// </summary>
        /// <param name="s1">1-ая сторона</param>
        /// <param name="s2">2-ая сторона</param>
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        private double AreaCalculator()
        {
            return side1 * side2;
        }

        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        /// <returns>Периметр прямоугольника</returns>
        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        public double Area
        {
            get { return AreaCalculator(); }
        }

        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
