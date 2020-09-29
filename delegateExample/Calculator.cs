using System;
using System.Collections.Generic;
using System.Text;

namespace delegateExample
{
    public class Calculator
    {
        public double Average(List<int> values)
        {
            double sum = 0.0;
            foreach(int i in values)
            {
                sum += i;
            }
            return sum / values.Count;
        }
        public double Min(List<int> values)
        {
            double min = values[0];
            for(int i = 1; i < values.Count; i++)
            {
                if (values[i] < min) min = values[i];
            }
            return min;
        }
        public double Max(List<int> values)
        {
            double max = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] >max) max = values[i];
            }
            return max;
        }
        public double Range(List<int> values)
        {
            return Max(values) - Min(values);
        }
    }
}
