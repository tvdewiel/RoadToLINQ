using System;
using System.Collections.Generic;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> values = new List<int>() { 10, 2, 3, 4, 5 };
            DataProcessor dataProcessor = new DataProcessor(values);
            Calculator calculator = new Calculator();

            dataProcessor.SetMethod(calculator.Average);
            dataProcessor.SetPrint((v)=> {
                Console.WriteLine($"CSV:{string.Join(",", v)}");
            });
            dataProcessor.PrintValues();
            dataProcessor.ProcessValues();
            dataProcessor.PrintResult();

            dataProcessor.SetMethod(calculator.Range);
            dataProcessor.SetPrint((v)=> {
                foreach (int i in v)
                {
                    Console.WriteLine($"value i : {i}");
                }
            });
            dataProcessor.PrintValues();
            dataProcessor.ProcessValues();
            dataProcessor.PrintResult();
        }
    }
}
