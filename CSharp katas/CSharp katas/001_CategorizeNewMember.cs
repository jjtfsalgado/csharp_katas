using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //your code here
            return data.Select(i =>
            {
                if (i[0] >= 55 && i[1] > 7)
                {
                    return "Senior";
                }
                else
                {
                    return "Open";
                }
            }).ToList();
        }
    }
}
