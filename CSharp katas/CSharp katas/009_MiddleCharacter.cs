using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class MiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            var leng = s.Length;
            decimal middle = leng / 2;

            var isEven = (leng % 2 == 0);

            if (isEven)
            {
                int num = Decimal.ToInt32(Math.Ceiling(middle));
                return $"{s[num-1]}{s[num]}";
            }
            else
            {
                int num = Decimal.ToInt32(Math.Floor(middle));
                return $"{s[num]}";
            }
        }
    }
}
