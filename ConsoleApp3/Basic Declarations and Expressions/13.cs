using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _13
    {
        /*Write a C# program to create a new string from a given string (length 1 or more ) 
         * with the first character added at the front and back. */

        static void Main (string [] args)
        {
            string str;
            
            Console.Write("Input a string: ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
                Console.ReadKey();
            }
        }
    }
}
