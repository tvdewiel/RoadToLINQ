using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string SurroundWith(this string s,string extra)
        {
            return extra + s + extra;
        }
    }
}
