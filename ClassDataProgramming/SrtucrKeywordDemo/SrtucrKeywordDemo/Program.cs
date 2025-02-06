using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrtucrKeywordDemo
{
    struct Students
    {
        public int roll;
        public string name;


    };// representing the block of code
    class Program
    {
        static void Main(string[] args)//create struct obj inside main
        {
            Students s1; //strucure is block of code when we write  struct hen new memory allocated  so we do not use new memory allocation keyword
            s1.name = "Rakesh";
            s1.roll = 101;
            Console.WriteLine(s1.roll);
            Console.WriteLine(s1.name);
            Console.ReadKey();
        }
    }
}
