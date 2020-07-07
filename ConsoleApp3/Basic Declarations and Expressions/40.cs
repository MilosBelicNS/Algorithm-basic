using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _40
    {
        //Write a C# program to create a new string of every other character (odd position) from the first position of a given string.

       
        public static void Main(string[] args)
        {
            Console.Write("Input new string: ");
            string str = Console.ReadLine();

           var result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    result += str[i];
            }
            Console.Write(result);
            Console.ReadKey();

           
        }

    }
}         
