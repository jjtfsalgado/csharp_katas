using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_katas
{
    class MakeComplement
    {
        public class DNA
        {
            public DNA()
            {
            }

            public string A { get; set; }
            public string T { get; set; }
            public string G { get; set; }
            public string C { get; set; }
        }

        public static Dictionary<char, string> mappedValue = new Dictionary<char, string>() {
            { 'A', "T" },
            { 'T', "A" },
            { 'G', "C" },
            { 'C', "G" }
        };

        public static string Get(string dna)
        {
            var array = dna.ToCharArray();

            var res = array.Select(i => mappedValue[i]);

            return string.Join("", res);
        }


    }
}
