using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Referece type
    public class GC_Class<T> where T : new()
    {
        public T Username;

        public int userid;


        public GC_Class(int a) { 
        
        }

        public void GC_Class_GET(T item)
        {
            Console.WriteLine($"Username : {Username}");
            Console.WriteLine($"item : {item}");
            //Console.WriteLine("Username : " + Username);
        }

    }

    // Value type
    public class GC_Struct<T> where T : struct
    {
        public T Username;

        public int userid;

        public void GC_Struct_GET(T item)
        {
            Console.WriteLine($"Username : {Username}");
            Console.WriteLine($"item : {item}");
            //Console.WriteLine("Username : " + Username);
        }

    }

}
