using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int Experience { get; set; }

        public Employee(string firstName, string lastName, string title, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Experience = experience;
        }

        public double Oklad()
        {
            double oklad;
            switch (Title)
            {
                case "Junior":
                    oklad = 70000;
                    break;
                case "Middle":
                    oklad = 150000;
                    break;
                case "Team Lead":
                    oklad = 300000;
                    break;
                default:
                    oklad = 50000;
                    break;
            }
            // За каждый год опыта +1% к окладу
            oklad = oklad + oklad / 100 * Experience;

            return Math.Round(oklad, 2);
        }

        public double Nalog() // Допустим налог будет 13% от оклада
        {
            return Math.Round(Oklad() * 0.13, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность: {2}\nОпыт: {3}\nОклад: {4}\nНалог: {5}", FirstName, LastName, Title, Experience, Oklad(), Nalog());
        }
    }
}
