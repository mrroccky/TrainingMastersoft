using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace StackDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            //pudh element
            s1.Push('A');
            s1.Push('B');
            s1.Push('C');
            s1.Push('D');

            foreach (char i in s1)
            {
                Console.WriteLine(i);
            }
            //depslay eleement
            Console.WriteLine("*************POP************");
            s1.Pop();
            foreach (char i in s1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
