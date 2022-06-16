using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Store
    {
        private Article[] articles = null;

        public Store(Article[] a)
        {
            articles = a;
        }

        // вывод информации о товаре по номеру с помощью индекса
        public void GetArticle(int n)
        {
            try
            {
                Console.WriteLine(articles[n].Name + " --- " + articles[n].Store + " --- " + articles[n].Price);
            }
            catch
            {
                Console.WriteLine("Индекс за пределами массива!"); 
            }
        }

        // вывод на экран информации о товаре, название которого введено с
        // клавиатуры, если таких товаров нет, выдать соответствующее сообщение
        public void FindArticle(string n)
        {
            List<Article> l = new List<Article>();
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Name.Contains(n))
                {
                    l.Add(articles[i]);
                }
            }
            
            if (l.Count > 0)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    Console.WriteLine(l[i].Name + " --- " + l[i].Store + " --- " + l[i].Price);
                }
            }
            else
            {
                Console.WriteLine("Товар не найден!");
            }
        }
    }
}
