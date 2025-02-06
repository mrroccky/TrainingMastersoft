using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Student3
    {
        int roll1;
        string name1;
        string branch1;
        int total;
        int grace =0;
        string result;
        const int PassingMarks = 40;
        
        public void input(int roll, string name, string branch, int m1, int m2, int m3, int m4, int m5)
        {
            this.roll = roll;
            this.name = name;
            this.branch = branch;
            
            if (m1 > PassingMarks && m2 > PassingMarks && m3 > PassingMarks && m4 > PassingMarks && m5 > PassingMarks)
            {
                total = m1 + m2 + m3 + m4 + m5;
                grade(total);
            }
            else
            {
                total = m1 + m2 + m3 + m4 + m5;
                result = "Result: Fail";
            }
        }

        private void grade(int total)
        {
            string grade;
            
            if (total >= 250)
            {
                grace = 150;
                total =total+ grace;
                grade = "A";
            }
             else if (total > 150 && total<250)
            {
                grace = 50;
                total =total+ grace;
                grade = "B";
            }
            else
            {

                result = "Result: Fail";
        
            }

            
            result = "Grade: " + grade + " Grace Marks: " + grace;
        }

        public void display()
        {
            Console.WriteLine("***************** RESULT *****************");
            Console.WriteLine("Student Roll Number: " + roll);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Branch: " + branch);
            Console.WriteLine("Student Total Marks: " + total);
            Console.WriteLine("Student Grace Marks: " + grace);
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*************** Only For Teachers ****************");
            
            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine());           
            Console.Write("Enter Name: ");
                string name = Console.ReadLine();            
            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();          
            Console.Write("Enter m1: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter m2: ");
                int m2 = int.Parse(Console.ReadLine());
            Console.Write("Enter m3: ");
            int m3 = int.Parse(Console.ReadLine());
            Console.Write("Enter m4: ");
            int m4 = int.Parse(Console.ReadLine());
            Console.Write("Enter m5: ");
            int m5 = int.Parse(Console.ReadLine()); 
            Student student = new Student();
            student.input(roll, name, branch, m1, m2, m3, m4, m5);
            student.display();
            
            Console.ReadKey();
        }
    }
}
