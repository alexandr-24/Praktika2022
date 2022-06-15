using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public Point (int X, int Y, string Name)
        {
            x = X;
            y = Y;
            name = Name;
        }

        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
