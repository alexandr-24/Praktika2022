using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string fn = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string ln = Console.ReadLine();
            Console.Write("Введите должность(Junior, Middle, Team Lead): ");
            string t = Console.ReadLine();
            Console.Write("Введите опыт работы: ");
            int ex = Convert.ToInt32 (Console.ReadLine());

            Employee person1 = new Employee(fn, ln, t, ex);
            person1.GetInfo();

            Console.ReadKey();
        }
    }
}
