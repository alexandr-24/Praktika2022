using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    struct MyStruct
    {
        public string Change { get; set; }
    }
    
    class MyClass
    {
        public string Change { get; set; }
    }

    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено";
        }

        static void Main(string[] args)
        {
            MyStruct s = new MyStruct();
            s.Change = "Не изменено";
            StruktTaker(s);
            Console.WriteLine(s.Change);

            MyClass c = new MyClass();
            c.Change = "Не изменено";
            ClassTaker(c);
            Console.WriteLine(c.Change);

            Console.ReadKey();
        }
    }
}
