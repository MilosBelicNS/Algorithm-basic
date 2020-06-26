using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _17
    {

        /*Write a C# program to check the sum of the two given integers and return true if one of the integer
          is 20 or if their sum is 20 */
        public static void Main(string [] args)
        {
            //int result;
            Console.WriteLine("Input first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

           
           
            Console.WriteLine(a == 20 || b == 20 || (a + b == 20));

            Console.ReadKey();


        }
    }
}
