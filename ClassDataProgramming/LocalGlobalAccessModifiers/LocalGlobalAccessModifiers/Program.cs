using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalGlobalAccessModifiers
{
    class Program
    {
        
        int rollglob;//this is a global variable
        void input(int roll)
        {
            rollglob = roll; //global = local
        }
        void display()
        {
            Console.WriteLine(rollglob);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.input(2000);
            p1.display();

            Console.ReadKey();
        }
    }
}
