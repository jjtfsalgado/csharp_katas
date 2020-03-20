using System;
using System.Linq;

namespace CSharp_katas
{
    class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            var arr = (s1 + s2).ToCharArray();
            Array.Sort(arr);
            return String.Join("", arr.Distinct());
        }
    }
}
