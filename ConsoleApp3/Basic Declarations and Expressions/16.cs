using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _16
    {
        /* Write a C# program to get the absolute value of the difference(razlika/oduzimanje) between two given numbers. 
         * Return double the absolute value of the difference if the first number is greater than second number */
        public static void Main (string [] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Result(a, b));

            Console.ReadKey();



        }

        public static int Result(int a, int b)
        {
            if(a > b)
            {
                return (a - b) * 2;
            }
            return b - a;

            // return  a >b? (a - b) * 2 : b - a; 
        }
    }
}
