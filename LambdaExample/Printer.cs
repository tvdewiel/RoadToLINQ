using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExample
{
    public static class Printer
    {
        public static void PrintCSV(List<int> values)
        {
            Console.WriteLine($"CSV:{string.Join(",", values)}");
        }
        public static void PrintLines(List<int> values)
        {
            foreach (int i in values)
            {
                Console.WriteLine($"value : {i}");
            }
        }
    }
}
