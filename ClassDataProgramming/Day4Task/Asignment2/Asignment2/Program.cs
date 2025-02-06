using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment2
{
    class Student
    {
        int total, grace, roll1;
        string result, name1,branch1;
        public void input(int roll, string name, string branch, int m1, int m2, int m3, int m4, int m5)
        {
            name1 = name;
            roll1 = roll;
            branch1=branch;
            if (m1 > 40 && m2 > 40 && m3 > 40 && m4 > 40 && m5 > 40)
            {
                total = m1 + m2 + m3 + m4 + m5;
                grade();
            }
            else
            {
                total = m1 + m2 + m3 + m4 + m5;
                grace=0;
                result = "Result Fail";
            }
        }
       void grade()
        {

            if (total >= 250)
            {
                grace =150;
                total = total + grace;
                result = "Grade : A Grace Marks: ";
            }
            else if (total > 150 && total < 250)
            {
                grace = 50;
                total = total + grace;
                result = "Grade : B Grace Marks: ";
            }
            else
            {
                grace=0;
                result = "Result Fail";
            }
            
        }
        public void display()
        {
            Console.WriteLine("Student Roll Number :" + roll1);
            Console.WriteLine("Student Name :" + name1);
            Console.WriteLine("branch Name :" + branch1);
            Console.WriteLine("Student Result :" + result);
            Console.WriteLine("Student Garace mark :" + grace);
            Console.WriteLine("Student Result total mark after grace :" + total);
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int roll, m1, m2, m3, m4, m5;
            string name, branch;
            Student obj = new Student();
            Console.WriteLine("*************** Only For Teachers ****************");
            Console.WriteLine("Enter Roll Number");
            roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
                Console.WriteLine("Enter Branch");
            branch = Console.ReadLine();
            Console.WriteLine("Enter m1");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m2");
            m2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m3");
            m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m4");
            m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m5");
            m5 = int.Parse(Console.ReadLine());
            obj.input(roll: roll, name: name, branch: branch, m1: m1, m2: m2, m3: m3, m4: m4, m5: m5);
            Console.WriteLine("*****************RESULT*****************");

            obj.display();
            Console.ReadKey();
        }
    }
}
