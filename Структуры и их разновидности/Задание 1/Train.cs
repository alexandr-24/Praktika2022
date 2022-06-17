using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Train
    {
        public string punkt { get; }
        public int nomer { get; }
        public string time { get; }

        public Train(string Punkt, int Nomer, string Time)
        {
            punkt = Punkt;
            nomer = Nomer;
            time = Time;
        }

        public void GetInfo()
        {
            Console.WriteLine("Номер поезда: {0}\nПункт назначения: {1}\nВремя отправления: {2}", nomer, punkt, time);
        }
    }
}
