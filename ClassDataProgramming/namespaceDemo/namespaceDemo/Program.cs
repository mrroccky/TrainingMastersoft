using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaceDemo
{
    namespace Collage
    {
        class Student
        {
          public void show()
            {
                Console.WriteLine("Stu");

            }
        }
        class Dept
        {
            public void Show()
            {
                Console.WriteLine("Dept");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Collage.Student Obj_Student = new Collage.Student();
            Collage.Dept obj_Department = new Collage.Dept();
            Obj_Student.show();
            obj_Department.Show();
            Console.ReadKey();
        }
    }
}
