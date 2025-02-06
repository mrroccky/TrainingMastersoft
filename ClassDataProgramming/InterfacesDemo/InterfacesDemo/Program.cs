using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    interface Student // create interface
    {
        //declare only methods 
        void display();
    }
    interface Collage
    {
        void show();
    }
    class Information : Student,Collage
    {
        public void display()
        {
            Console.WriteLine("display ");
        }
        public void show()
        {
            Console.WriteLine("hellow show ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Information i1 = new Information();
            i1.display();
            i1.show();

            Console.ReadKey();
        }
    }
}
