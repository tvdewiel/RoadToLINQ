using System;
using System.Collections.Generic;
using System.Text;

namespace FuncActionExample
{
    public class DataProcessor
    {      
        private Func<List<int>,double> Process;
        private Action<List<int>> PrintOut;
        private List<int> _values = new List<int>();
        private double _result;

        public DataProcessor(List<int> values)
        {
            _values = values;
        }
        public void SetMethod(Func<List<int>, double> method)
        {
            Process = method;
        }
        public void SetPrint(Action<List<int>> print)
        {
            PrintOut = print;
        }
        public void ProcessValues()
        {
            _result=Process(_values);
        }
        public void PrintValues()
        {
            PrintOut(_values);            
        }
        public void PrintResult()
        {
            Console.WriteLine($"result : {_result}");
        }
    }
}
