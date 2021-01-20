using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[]{"ali","ahmet"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);

            //names = new string[3];
            //names[2] = "yusuf";
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[1]);

            List<string> names2 = new List<string> { "ali", "ahmet" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            names2.Add("yusuf");
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[1]);





        }
    }
}
