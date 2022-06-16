using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    public class Invoice
    {
        public readonly int Account; // Счет
        public readonly string Customer; // Клиент
        public readonly string Provider; // Поставщик

        private string _article; // Изделие
        private int _quantity; // Количество

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine("Клиент: {0}\nПоставщик: {1}\nТовар: {4} ({5})\nЦена без НДС: {2}\nЦена с НДС: {3}", Customer, Provider, Account, GetAccountWithNds(), _article, _quantity);
        }
    }
}
