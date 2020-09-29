using System;
using System.Collections.Generic;
using System.Text;

namespace delegateExample
{
    public class DataProcessor
    {
        public delegate double ProcessMethod(List<int> values);
        private ProcessMethod Process;
        private List<int> _values = new List<int>();
        private double _result;

        public DataProcessor(List<int> values)
        {
            _values = values;
        }

        public void SetMethod(ProcessMethod method)
        {
            Process = method;
        }
        public void ProcessValues()
        {
            _result=Process(_values);
        }
        public void PrintValues()
        {
            foreach(int i in _values)
            {
                Console.WriteLine($"value : {i}");
            }
        }
        public void PrintResult()
        {
            Console.WriteLine($"result : {_result}");
        }
    }
}
