using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string x = "hello";
            Console.WriteLine(x.SurroundWith("***"));


            List<int> xc = new List<int> { 0, 5, 10 };
            List<int> yc = new List<int> { 0, 5, 10 };
            Segment s = new Segment(xc, yc);

            Console.WriteLine($"segment lengte:{s.Length()}");
        }
    }
}
