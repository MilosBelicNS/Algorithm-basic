using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _47
    {

        //Write a C# program to get the larger value between first and last element of an array (length 3) of integers.

        public static void Main (string [] args)
        {
            //int[] niz = { 1, 2, 5, 7, 8 };
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", niz));
            //var h_value = niz[0];
            //for(var i = 0; i < niz.Length; i++)
            //{
            //    if (niz[i] > niz[0])
            //        h_value = niz[i];

            //}
            //Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_value);
            //Console.ReadKey();


            //DRUGI NACIN
            int[] niz = { 1, 2, 8, 17 };
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", niz));
            int nizMax = niz.Max();
            Console.WriteLine("\nHighest value between first and last values of the said array: {0}", nizMax);
            Console.ReadKey();

        }

    }
}
