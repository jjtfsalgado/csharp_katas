using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_katas
{
    class NeedleInTheHaystack
    {
        public static string Get(object[] data)
        {
           return $"found the needle at position {Array.IndexOf(data, "needle")}";
        }
    }
}
