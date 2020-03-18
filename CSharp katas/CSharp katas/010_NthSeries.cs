using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_katas
{
    class NthSeries
    {
        public static string seriesSum(int n)
        {
            if (n == 0) return "0.00";

            decimal result = 1.00m;
            var number = 1;

            for (int i = 1; i < n; i++)
            {
                number += 3;
                result = Decimal.Add(result, Decimal.Divide(1 , number));
            }

            return result.ToString("0.00");
        }
    }
}
