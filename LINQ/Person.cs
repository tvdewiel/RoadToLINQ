using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Person
    {
        public int length { get; set; }
        public double weight { get; set; }
        public string name { get; set; }
        public char sex { get; set; }

        public Person(int length, double weight, string name,char sex)
        {
            this.length = length;
            this.weight = weight;
            this.name = name;
            this.sex = sex;
        }
        override
            public string ToString()
        {
            return $"Person:{name},length:{length},weight:{weight},sex:{sex}";
        }
    }
}
