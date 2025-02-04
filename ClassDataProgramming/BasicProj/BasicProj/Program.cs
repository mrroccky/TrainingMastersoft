using System; //'using' keyword is used refrence library 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProj
{
    class Program   //this is called main class 
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());

             if (age > 18)
            {
                Console.WriteLine("You Can Vote");
            }
            else
            {
                Console.WriteLine("You Can Vote");
            }
            Console.ReadKey();
        }
    }
}
