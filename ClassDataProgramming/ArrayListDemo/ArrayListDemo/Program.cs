using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            ArrayList obj_A1 = new ArrayList();
            Console.WriteLine("Enter number of element ");
            int number = int.Parse(Console.ReadLine());
            for(int i=0; i < number; i++)
            {
                Console.WriteLine("Enter element number :" + i);
                obj_A1.Add(int.Parse(Console.ReadLine()));
            }

            foreach(int n in obj_A1)
            {
                Console.WriteLine(n);
            }
            //Arrange arraylist elements
            obj_A1.Sort();
            Console.WriteLine("***********Rarrange element**********");
            foreach (int n in obj_A1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("***********Remove element**********");
            obj_A1.Remove(5);
            foreach (int n in obj_A1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("***********Count element**********");
            obj_A1.Count;
            Console.WriteLine(obj_A1);
            

            Console.ReadKey();

        }
    }
}
