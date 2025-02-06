using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters
{
    class Program
    {
        void dispaly(string message)
        {
            Console.WriteLine(message);
        }
        void displayint(int a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any message");
            string message = Console.ReadLine();
            int n;
            Console.WriteLine("enter any number");
            n = int.Parse( Console.ReadLine());
            Program p1 = new Program();
            p1.dispaly("hello potter");
            p1.displayint(n:n);
            Console.ReadKey();
        }
    }
}
