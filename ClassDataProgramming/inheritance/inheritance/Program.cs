using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("this is base class");
        }
    }
    class B :A //inheretance
    {
        public void Show()
        {
            Console.WriteLine("this is derived class");
        }
    }
    class C : B {
        public void Great()
        {
            Console.WriteLine("this is chaining miltiple inheritance class");
        }
    }
      
    class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.Display();
            c1.Show();
            c1.Great();
            Console.ReadKey();
        }
    }
}
