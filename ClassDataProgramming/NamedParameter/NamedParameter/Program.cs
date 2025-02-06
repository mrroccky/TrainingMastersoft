using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        void input(int roll, string name)
        {
            Console.WriteLine("Roll : " + roll + "Name :" + name);
        }
        static void Main(string[] args)
        {
            int roll1;
            string name1;
            Console.WriteLine("Enter roll number");
            roll1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name1 = Console.ReadLine();
            
            Program p1 = new Program();
            //pass parameter using unnamed concept
            //p1.input(name1,roll1);
            //pass parameter using named concept
            p1.input(name: name1, roll: roll1);
            Console.ReadKey();
        }
    }
}
