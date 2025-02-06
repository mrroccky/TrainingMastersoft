using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2trycatch_classandobject
{
    class Student
    {
        int roll;
        string name;
        string branch;
        int total;
        int grace = 0;
        string result;
        const int PassingMarks = 40;

        // Method to take input and calculate result
        public void input(int roll, string name, string branch, int marks_Sub1, int marks_sub2, int marks_sub3, int marks_Sub4, int marks_sub5)
        {
            try
            {
                // Checking if any marks are negative
                if (marks_Sub1 < 0 || marks_sub2 < 0 || marks_sub3 < 0 || marks_Sub4 < 0 || marks_sub5 < 0)
                {
                    throw new Exception("Marks cannot be negative.");
                }

                this.roll = roll;
                this.name = name;
                this.branch = branch;

                total = marks_Sub1 + marks_sub2 + marks_sub3 + marks_Sub4 + marks_sub5;

                // Checking if student has passed all subjects
                if (marks_Sub1 >= PassingMarks && marks_sub2 >= PassingMarks && marks_sub3 >= PassingMarks && marks_Sub4 >= PassingMarks && marks_sub5 >= PassingMarks)
                {
                    grade(total);
                }
                else
                {
                    result = "Result: Fail";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to determine grade and assign grace marks
        private void grade(int total)
        {
            if (total >= 250)
            {
                grace = 150;
                total += grace;
                result = "Grade: A | Grace Marks: " + grace;
            }
            else if (total > 150 && total < 250)
            {
                grace = 50;
                total += grace;
                result = "Grade: B | Grace Marks: " + grace;
            }
            else
            {
                result = "Result: Fail";
            }
        }

        // Method to display student details and result
        public void display()
        {
            Console.WriteLine("\n***************** RESULT *****************");
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
            try
            {
                Console.WriteLine("*************** Only For Teachers ****************");

                // Taking student details input
                Console.Write("Enter Roll Number: ");
                int roll = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Branch: ");
                string branch = Console.ReadLine();

                Console.Write("Enter Marks for 5 subjects:");
                Console.Write("\nEnter marks_Sub1: ");
                int marks_Sub1 = int.Parse(Console.ReadLine());

                Console.Write("Enter marks_sub2: ");
                int marks_sub2 = int.Parse(Console.ReadLine());

                Console.Write("Enter marks_sub3: ");
                int marks_sub3 = int.Parse(Console.ReadLine());

                Console.Write("Enter marks_Sub4: ");
                int marks_Sub4 = int.Parse(Console.ReadLine());

                Console.Write("Enter marks_sub5: ");
                int marks_sub5 = int.Parse(Console.ReadLine());

                // Creating student object and processing result
                Student student = new Student();
                student.input(roll, name, branch, marks_Sub1, marks_sub2, marks_sub3, marks_Sub4, marks_sub5);
                student.display();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in main: " + ex.Message);
            }

            Console.ReadKey(); // Pause the console to view the output
        }
    }
}
