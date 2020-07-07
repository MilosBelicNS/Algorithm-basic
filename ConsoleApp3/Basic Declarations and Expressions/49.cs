using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _49
    {
        //Write a C# program to check if an array contains an odd number.
        public static void Main ()
        {
            int[] niz = { 2, 4, 7, 8, 9 };
            Console.WriteLine("\n Original array: [{0}]", string.Join(", ", niz));
            Console.WriteLine("Check if an array contains an odd number? "+ Even_odd(niz));
            Console.ReadKey();

        }
        public static bool Even_odd(int[] niz)
        {
            foreach(var n in niz)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
