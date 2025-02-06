using System;

namespace Assignment3_1trycatch
{
    class Collage
    {
        int total;
        public void Result(int marks_sub1, int marks_sub2, int marks_sub3, int marks_sub4, int marks_sub5)
        {
            try
            {
                total = marks_sub1 + marks_sub2 + marks_sub3 + marks_sub4 + marks_sub5;
                Console.WriteLine("Total Marks: " + total);
            }
            catch (Exception)
            {
                Console.WriteLine("Error in calculation.");
                throw;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("************* Marksheet *****************");

                // Taking and converting input for five subjects
                Console.WriteLine("Enter marks for 1st subject:");
                int marks_sub1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks for 2nd subject:");
                int marks_sub2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks for 3rd subject:");
                int marks_sub3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks for 4th subject:");
                int marks_sub4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter marks for 5th subject:");
                int marks_sub5 = int.Parse(Console.ReadLine());

                Collage collage = new Collage();

                // Calling the Result method with integer values
                collage.Result(marks_sub1, marks_sub2, marks_sub3, marks_sub4, marks_sub5);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
                throw Exception("Invalid input! Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }

            Console.ReadKey();
        }
    }
}
