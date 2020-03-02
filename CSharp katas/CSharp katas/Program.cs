using System;

namespace CSharp_katas
{
    class Program
    {
        static void Main(string[] args)
        {

            //001
            //var result = CategorizeNewMember.OpenOrSenior(new int[][] { new int[] { 18, 20 }, new int[] { 45, 2 }, new int[] { 61, 12 }, new int[] { 37, 6 }, new int[] { 21, 21 }, new int[] { 78, 9 } });


            //002
            //var result = MakeComplement.Get("ATTGC");

            //003
            //var result = ConvertNumberToString.Convert(1234);

            //004
            var result = ConvertNumberToReversed.convert(348597);

            Array.ForEach(result, Console.WriteLine);

            Console.WriteLine("Hello World!");
        }
    }
}
