using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    struct Student
    {
        public int roll, m1, m2, m3, m4, m5;
        public string name, city;
    }

    enum City
    {
        Nagpur,
        Pune,
        Mumbai
    }

    class Collage
    {
        public int total, grace;
        public string name1, city1, branch, result;
        public int roll1;

        public void input(string city, string name, int roll, int m1, int m2, int m3, int m4, int m5)
        {
            name1 = name;
            city1 = city;
            roll1 = roll;

            if (m1 > 40 && m2 > 40 && m3 > 40 && m4 > 40 && m5 > 40)
            {
                total = m1 + m2 + m3 + m4 + m5;
                if (total > 250)
                {
                    grace = 150;
                    total = grace + total;
                    result = "Grade A";
                }
                else if (total > 150 && total < 250)
                {
                    grace = 50;
                    total = grace + total;
                    result = "Grade B";
                }
                else
                {
                    grace = 0;
                    total = grace + total;
                    result = "Fail";
                }
            }
            else
            {
                grace = 0;
                total = grace + total;
                result = "Fail";
            }
        }

        public void display()
        {
            Console.WriteLine("***************** RESULT *****************");
            Console.WriteLine("Student Roll Number: " + roll1);
            Console.WriteLine("Student Name: " + name1);
            Console.WriteLine("Student City: " + city1);
            Console.WriteLine("Student Total Marks: " + total);
            Console.WriteLine("Student Grace Marks: " + grace);
            Console.WriteLine("Student Result: " + result);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("***************** only for *****************");
            Student s1;
            Console.WriteLine("Enter Roll");
            s1.roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            s1.name = Console.ReadLine();
            s1.city = City.Mumbai.ToString();
            Console.WriteLine("Enter m1");
            s1.m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m2");
            s1.m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m3");
            s1.m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m4");
            s1.m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m5");
            s1.m5 = int.Parse(Console.ReadLine());

            Collage c1 = new Collage();
            c1.input(city: s1.city, name: s1.name, roll: s1.roll, m1: s1.m1, m2: s1.m2, m3: s1.m3, m4: s1.m4, m5: s1.m5);
            c1.display();
            Console.ReadKey();
        }
    }
}