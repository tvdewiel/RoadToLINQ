using System;
using System.Collections.Generic;

namespace FuncActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> values = new List<int>() { 1, 2, 3, 4, 5 };
            DataProcessor dataProcessor = new DataProcessor(values);
            Calculator calculator = new Calculator();

            dataProcessor.SetMethod(calculator.Average);
            dataProcessor.SetPrint(Printer.PrintCSV);
            dataProcessor.PrintValues();
            dataProcessor.ProcessValues();
            dataProcessor.PrintResult();

            dataProcessor.SetMethod(calculator.Range);
            dataProcessor.SetPrint(Printer.PrintLines);
            dataProcessor.PrintValues();
            dataProcessor.ProcessValues();
            dataProcessor.PrintResult();
        }
    }
}
