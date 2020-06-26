using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _31
    {
           /* Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. Go to the editor
             Sample Output:
          Input a first number(<100): 75
          Input a second number(>100): 250
           True */

        public static void Main (string [] args)
        {
            Console.WriteLine("\n Input first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a < 100 || b > 200);
            Console.ReadKey();


        }
    }
}
