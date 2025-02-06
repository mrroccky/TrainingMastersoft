using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ShortedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object
            SortedList<int, string> s1 = new SortedList<int, string>();
            //input data element
            s1.Add(5,"Nagpur");
            s1.Add(19, "Mumbai");
            s1.Add(1, "Pune");

            foreach(var k in s1)
            {
                //pair object is used to dynamic variable ->   var
                Console.WriteLine("key : "+k.Key,"val :"+ k.Value);

            }

            Console.ReadKey();
        }
    }
}
