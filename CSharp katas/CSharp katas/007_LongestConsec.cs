using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class LongestConsec
    {
        public static string Get(string[] strarr, int k)
        {
            string result = "";

            if (k < 0) return result;

            for (int i = 0; i <= strarr.Length - k; i++)
            {
                var seg = new ArraySegment<string>(strarr, i, k);

                var temp = String.Join("", seg);
                
                if(temp.Length > result.Length)
                {
                    result = temp;
                }
            }

            return result;
        }
    }
}
