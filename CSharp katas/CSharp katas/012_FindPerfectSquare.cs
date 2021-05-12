using System;
using System.Linq;

namespace CSharp_katas
{
    class FindPerfectSquare
    {
        public static long FindNextSquare(long num)
        {
            var n = Math.Sqrt(num);
            if ((n % 1) != 0) return -1;

            ++num;
            
            while ((Math.Sqrt(num) % 1) != 0)
            {
                ++num;
            }

            return num;
        }

        private static long FindNextSquareRecur(long num)
        {
            var result = Math.Sqrt(num);

            if ((result % 1) == 0) return num;

            return FindNextSquareRecur(num + 1);
        }
    }
}
