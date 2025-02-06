using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    // Assignment 4
    class College
    {
        public string studentName, cBranch;
        public int rollNumber, total;
        
        public void basic_info(int roll, string name, string branch, int m1, int m2, int m3, int m4, int m5)
        {
            rollNumber = roll;
            studentName = name;
            cBranch = branch;
            // input all parameter by the user
             
            if(m1>40 && m2>40 && m3>40 && m4>40 && m5 > 40)
            {
                total = m1 + m2 + m3 + m4 + m5;
            }
            else
            {
                Console.WriteLine("Result : Fail");
            }
        }
    }

    class Student :College
    {
        public string result;
        public int grace;
        public int marksAfterGrace;
        public void grade(int total)
        {
            
            // Accept total and check the following condition (total > 250...)
            if (total >= 250)
            {
                result = "Grade A";
                grace = 150;
                
            }else if (total>150 && total<250)
            {
                grace = 50;
                result = "Grade B";
            }
            else
            {
                grace = 0;
                result = "Fail";
            }
            marksAfterGrace = total + grace;
        }
    }

    class Result : Student
    {
        public void display()
        {
            // Print all student information 
            Console.WriteLine("****************Student Result******************");

            Console.WriteLine("Student ID = " + rollNumber);
            Console.WriteLine("Student Name = "+studentName);
            Console.WriteLine("Student Branch = "+ cBranch);
            /////////
            Console.WriteLine("Student Total Marks = " +total);
            Console.WriteLine("Grace = " + grace);
            Console.WriteLine("Total After Grace = " + marksAfterGrace);
            Console.WriteLine("Result  = " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             int roll, m1, m2, m3, m4, m5;
            string name, branch;
            Console.WriteLine("****************Only For teachers******************");
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
           
             Result res = new Result();
            res.basic_info(roll: roll, name: name, branch: branch, m1: m1, m2: m2, m3: m3, m4: m4, m5: m5);
            res.grade(res.total);
            res.display();
            // hold console screen
            Console.ReadKey();
        }
    }
}
