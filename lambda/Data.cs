using System;
using System.Collections.Generic;
using System.Text;

namespace lambda
{
    public class Data
    {
        public int x {get; set;}
        public int y { get; set; }
        public string name { get; set; }

        public Data(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
