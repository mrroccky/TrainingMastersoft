using System;

namespace Assignment_4_Abstract_Student_Grade
{
    //this is abstract class which tell collages how to perform grade and show result
    abstract class University
    {
        public abstract void Checker(int roll, string name, string branch, int marks_sub_1, int marks_sub_2, int marks_sub_3, int marks_sub_4, int marks_sub_5);
        public abstract void DisplayResult();
    }

    class College : University
    {
        private int roll1, total, grace;
        private string name1, result, branch1;
        private string grade;
        private const int PassingMarks = 40;

        public override void Checker(int roll, string name, string branch, int marks_sub_1, int marks_sub_2, int marks_sub_3, int marks_sub_4, int marks_sub_5)
        {
            try
            {
                //assignning data from local to global variable
                this.roll1 = roll;
                this.name1 = name;
                this.branch1 = branch;

                if (marks_sub_1 >= PassingMarks && marks_sub_2 >= PassingMarks && marks_sub_3 >= PassingMarks && marks_sub_4 >= PassingMarks && marks_sub_5 >= PassingMarks)
                {
                    total = marks_sub_1 + marks_sub_2 + marks_sub_3 + marks_sub_4 + marks_sub_5;
                    AssignGrade(total);
                }
                else
                {
                    total = marks_sub_1 + marks_sub_2 + marks_sub_3 + marks_sub_4 + marks_sub_5;
                    result = "Result: Fail";
                    grade = "Fail";
                    grace = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in processing marks: " + ex.Message);
            }
        }
//asssignning grade
        private void AssignGrade(int total)
        {
            try
            {
                if (total >= 250)
                {
                    grace = 150;
                    total =total+ grace;
                    grade = "Grade A";
                }
                else if (total > 150 && total < 250)
                {
                    grace = 50;
                    total =total+ grace;
                    grade = "Grade B";
                }
                else
                {
                    result = "Result: Fail";
                    grade = "FAIL";
                    grace = 0;
                    return;
                }
                
                result = "Grade: " + grade + " Grace Marks: " + grace;
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro in assigning grade: " + ex.Message);
            }
        }
//to dispaly all data to student after result was declred
        public override void DisplayResult()
        {
            try
            {
                Console.WriteLine("***************** RESULT *****************");
                Console.WriteLine("Student Roll Number: " + roll1);
                Console.WriteLine("Student Name: " + name1);
                Console.WriteLine("Student Branch: " + branch1);
                Console.WriteLine("Student Total Marks: " + total);
                Console.WriteLine("Student Grace Marks: " + grace);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error showing  result: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                //we are getting user data
                Console.WriteLine("************* Marksheet *****************");
                Console.Write("Enter Student Roll Number: ");
                int roll = int.Parse(Console.ReadLine());
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Student Branch: ");
                string branch = Console.ReadLine();
                Console.Write("Enter marks for 1st subject: ");
                int marks1 = int.Parse(Console.ReadLine());
                Console.Write("Enter marks for 2nd subject: ");
                int marks2 = int.Parse(Console.ReadLine());
                Console.Write("Enter marks for 3rd subject: ");
                int marks3 = int.Parse(Console.ReadLine());
                Console.Write("Enter marks for 4th subject: ");
                int marks4 = int.Parse(Console.ReadLine());
                Console.Write("Enter marks for 5th subject: ");
                int marks5 = int.Parse(Console.ReadLine());
            //collage object 
                College obj_college = new College();
                obj_college.Checker(roll, name, branch, marks1, marks2, marks3, marks4, marks5);
                obj_college.DisplayResult();
            }
            catch (Exception ex)
            {
                //to check that user entered wrong data 
                Console.WriteLine("rorr in getting data: " + ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
