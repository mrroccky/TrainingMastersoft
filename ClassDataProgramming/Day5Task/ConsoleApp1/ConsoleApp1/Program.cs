using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Collage
    {
        int total;
        public void Result<T>(T marks_sub1,T marks_sub2, T marks_sub3, T marks_sub4,T marks_sub5)
        {
            try
            {
                total = (dynamic)marks_sub1 + (dynamic)marks_sub2 + (dynamic)marks_sub3 + (dynamic)marks_sub4 + (dynamic)marks_sub5;
                Console.WriteLine("Marks" + total);
            }
            catch(Exception){
                Console.WriteLine("Cannot Convert Sting to int provide proper marks");
                throw new Exception("Cannot Convert Sting to int provide proper marks");
            }
        }
    }
    class Program
    {
       
        static void Main()
        {
            string marks_sub1, marks_sub2, marks_sub3, marks_sub4, marks_sub5;
            Collage collage = new Collage();
            Console.WriteLine("*************Marksheet*****************");
            Console.WriteLine("Enter marks1st subject");
            marks_sub1 = Console.ReadLine();
            Console.WriteLine("Enter marks 2 st subject");
            marks_sub2 = Console.ReadLine();
            Console.WriteLine("Enter marks 3 st subject");
            marks_sub3 = Console.ReadLine();
            Console.WriteLine("Enter marks 4 st subject");
            marks_sub4 = Console.ReadLine();
            Console.WriteLine("Enter marks 5 st subject");
            marks_sub5 = Console.ReadLine();
            collage.Result(marks_sub1:marks_sub1,marks_sub2:marks_sub2,marks_sub3:marks_sub3,marks_sub4:marks_sub4,marks_sub5:marks_sub5);

            Console.ReadKey();

        }
    }
   
}
