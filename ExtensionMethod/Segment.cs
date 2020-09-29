using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public class Segment
    {
        public List<Point> points=new List<Point>();

        public Segment(List<int> xl, List<int> yl)
        {
            for(int i=0;i<xl.Count;i++) {
                points.Add(new Point(xl[i], yl[i]));
            }
        }
        public int getN()
        {
            return points.Count;
        }
    }
}
