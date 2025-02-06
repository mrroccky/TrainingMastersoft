using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassDemo
{
    class Generis_class
    {
        public void show<T>(T message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generis_class gn = new Generis_class();
            gn.show("Hellow World");
            gn.show(11);
            Console.ReadKey();
        }
    }
}
