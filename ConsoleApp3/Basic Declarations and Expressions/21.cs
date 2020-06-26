using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _21
    {
        //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.


        public static void Main ()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Print one number per line");
            for(int n = 1; n < (99 + 1); n++ )
            {
                if(n % 2 != 0)
                {
                    Console.WriteLine(n);
                    Console.ReadKey();

                }
            }
        }
    }
}
