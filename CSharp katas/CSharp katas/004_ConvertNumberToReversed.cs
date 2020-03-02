using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class ConvertNumberToReversed
    {
        public static long[] convert(long value)
        {
            return value.ToString().Reverse().Select(i => Convert.ToInt64(i.ToString())).ToArray();
        }
    }
}
