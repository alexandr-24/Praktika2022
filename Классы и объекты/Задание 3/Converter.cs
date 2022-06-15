using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter(double USD, double EUR, double RUB)
        {
            usd = USD;
            eur = EUR;
            rub = RUB;
        }

        public double ConvertToUSD(double UAH)
        {
            return Math.Round(UAH / usd, 2);
        }
        public double ConvertFromUSD(double USD)
        {
            return Math.Round(USD * usd, 2);
        }

        public double ConvertToEUR(double UAH)
        {
            return Math.Round(UAH / eur, 2);
        }
        public double ConvertFromEUR(double EUR)
        {
            return Math.Round(EUR * eur, 2);
        }

        public double ConvertToRUB(double UAH)
        {
            return Math.Round(UAH / rub, 2);
        }
        public double ConvertFromRUB(double RUB)
        {
            return Math.Round(RUB * rub, 2);
        }
    }
}
