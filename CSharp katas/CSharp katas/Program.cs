using System;

namespace CSharp_katas
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = CategorizeNewMember.OpenOrSenior(new int[][] { new int[] { 18, 20 }, new int[] { 45, 2 }, new int[] { 61, 12 }, new int[] { 37, 6 }, new int[] { 21, 21 }, new int[] { 78, 9 } });

            Console.WriteLine(string.Join("\t",result));

            Console.WriteLine("Hello World!");
        }
    }
}
