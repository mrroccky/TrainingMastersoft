using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionUserDefined
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("enter number");
            a = int.Parse(Console.ReadLine());
            Console.Write("enter number");
            b = int.Parse(Console.ReadLine());
            try
            {
                if (b == 0)
                {
                    //Exceprion is parameterised constructor
                    throw new Exception("Cant devide by zero");
                }
                c = a / b;
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
