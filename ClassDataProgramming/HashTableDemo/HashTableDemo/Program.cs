using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            //implimenting hash table
            //add data element in hash table
            ht1.Add("101", "Nagpur");
            ht1.Add("102", "PUNE");
            ht1.Add("103", "Mumbai");
            ht1.Add("104", "Indore");
            foreach(string key in ht1.Keys)
            {

                //display hash table element
                //hasttable has print data in random way 
                Console.WriteLine("key:  "+key+"   Values:  "+ht1[key]);
            }
            Console.ReadKey();
        }
    }
}
