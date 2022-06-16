using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Article
    {
        private string name;
        private string store;
        private double price;

        public string Name { get { return name; } }
        public string Store { get { return store; } }
        public double Price { get { return price; } }

        public Article(string Name, string Store, double Price)
        {
            name = Name;
            store = Store;
            price = Price;
        }
    }
}
