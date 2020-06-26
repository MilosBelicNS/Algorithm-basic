using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _14
    {
        //Write a C# program to check two given integers and return true if one is negative and one is positive.

        static void Main (string [] args)
        {
            Console.WriteLine("\nInput first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Check if one is negative and one is positive: ");
            Console.WriteLine((a < 0 && b > 0) || (a > 0 && b < 0));
            Console.ReadKey();
        }
    }
}
