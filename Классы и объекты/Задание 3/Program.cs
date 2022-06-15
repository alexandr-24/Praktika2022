using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter myConverter = new Converter(29.55, 30.96, 0.52);
            Console.WriteLine("1000 UAH: ");
            Console.WriteLine(myConverter.ConvertToUSD(1000) + " USD");
            Console.WriteLine(myConverter.ConvertToEUR(1000) + " EUR");
            Console.WriteLine(myConverter.ConvertToRUB(1000) + " RUB");

            Console.WriteLine("\n1000 USD = " + myConverter.ConvertFromUSD(1000) + " UAH");
            Console.WriteLine("1000 EUR = " + myConverter.ConvertFromEUR(1000) + " UAH");
            Console.WriteLine("1000 RUB = " + myConverter.ConvertFromRUB(1000) + " UAH");

            Console.ReadKey();
        }
    }
}
