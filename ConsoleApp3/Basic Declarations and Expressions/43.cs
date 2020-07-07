using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _43
    {
        // Write a C# program to compute the sum of all the elements of an array of integers.

        public static void Main (string [] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            var sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Suma elemenata u nizu: " + sum);
            Console.ReadKey();

            //drugi nacin 
            //int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Suma elemenata u nizu je: " + a.Sum());
            //Console.ReadKey();

        }
}
}
