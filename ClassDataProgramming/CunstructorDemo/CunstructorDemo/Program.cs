using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CunstructorDemo
{
    class Students
    {
        public Students(int a=5) //parameterised constructor
        {
            Console.WriteLine(a);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            Students s1 = new Students(1233); // it excecute automatically 
            Console.ReadKey();
        }
    }
}
