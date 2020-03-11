using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class Mumbling
    {
        public static string Accum(string s)
        {
            var result = new string[s.Length];

            var arr = s.ToLower().ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                var cur = arr[i].ToString();
                var j = cur.ToUpper() + string.Concat(Enumerable.Repeat(cur, i));

                result[i] = j;
            }

            return string.Join("-", result);
        }
    }
}
