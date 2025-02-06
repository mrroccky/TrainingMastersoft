using System;
using System.Collections.Generic;//library 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class GenericsClass<T> //this is called generics class
    {
        public GenericsClass(T msg) //msg accept all type of data value
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericsClass<string> obj = new GenericsClass<string>("hellow world im generic classs!");
            GenericsClass<int> obj1 = new GenericsClass<int>(11);

            Console.ReadKey();
        }
    }
}
