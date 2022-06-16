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
            MyMatrix matrix = new MyMatrix(2, 2);

            matrix.FeedMatrix();
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            matrix.ShowMatrix();

            matrix.ChangeMatrix(4, 4);
            matrix.FeedMatrix();
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            matrix.ShowMatrix();

            Console.ReadKey();
        }
    }
}
