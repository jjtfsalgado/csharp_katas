using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class HighestAndLowest
    {
        public static string get(string value)
        {
            var values = value.Split(" ").Select(i => Convert.ToInt64(i.ToString()));

            var max = values.Max();
            var min = values.Min();

            return $"{max} {min}";
        }
    }
}
