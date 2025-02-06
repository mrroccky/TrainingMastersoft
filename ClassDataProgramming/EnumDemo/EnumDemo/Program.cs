using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum city // to make value fix 
    {
        Nagpur,
        Pune,
        mumbai,
        indore
    }
    class Program
    {
        static void Main(string[] args)
        {
            //acess enum data
            Console.WriteLine(city.Pune);
            Console.WriteLine(city.mumbai);

            Console.ReadKey();
        }
    }
}
