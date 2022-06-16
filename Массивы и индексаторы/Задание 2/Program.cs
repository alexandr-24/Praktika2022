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
            Article a1 = new Article("Кружка", "Fix Price", 100);
            Article a2 = new Article("Гитара", "Музыкальный", 5000);
            Article a3 = new Article("Ноутбук", "МВидео", 25000);

            Store store = new Store(new Article[] { a1, a2, a3 });

            Console.Write("Поиск по индексу: ");
            store.GetArticle(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Поиск по названию: ");
            store.FindArticle(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
