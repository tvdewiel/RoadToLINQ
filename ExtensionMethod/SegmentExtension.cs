using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class SegmentExtension
    {
        public static double Length(this Segment s)
        {
            double l = 0.0;
            for(int i=1;i<s.getN();i++)
            {
                l += Math.Sqrt(Math.Pow(s.points[i].x-s.points[i-1].x, 2) 
                    + Math.Pow(s.points[i].y - s.points[i-1].y, 2));
            }
            return l;
        }
    }
}
