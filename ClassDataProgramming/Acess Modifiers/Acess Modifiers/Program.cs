using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acess_Modifiers
{
    class Student
    {

        //so the display called as methid
       public void dispaly(int a)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine(a);
        }
    }

    // in any opps language we cannot count  main class as class so in this program we have one class
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int n;
            Console.WriteLine("enter any number");
            n = int.Parse(Console.ReadLine());
            s1.dispaly(a:n);
            Console.ReadKey();
        }
    }
}
