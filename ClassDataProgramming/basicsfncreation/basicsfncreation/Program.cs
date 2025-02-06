using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicsfncreation
{
    class Program
    {
        // create a function
        void dispaly()
        {
            Console.WriteLine("hello potter");
        }
        static void Main(string[] args)
        {
            //creation of object
            //new = memeory allocation oprator
            Program myprogram = new Program();
            //calling function
            myprogram.dispaly();
            //program execution   display then -> object ->looking at class ->then find display() then execute
            //dot (.) is called acessiblity oprator 
            // all object oreinted programing follow bottom up approach

            Console.ReadKey(); // to hold console screen
        }
    }
}
