using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int c;
            try
            {
                //logic
                c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj);
                //return exception
            }

            Console.ReadKey();
        }
    }
}
