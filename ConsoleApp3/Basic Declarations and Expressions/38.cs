using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _38
    {
        //Write a C# program to create a new string where the first 4 characters will be in lower case. 
        //If the string is less than 4 characters then make the whole string in upper case.

        public static void Main ()
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4));
            Console.ReadKey();
            //Console.WriteLine("input a string");
            //string s = Console.ReadLine();

            //Console.WriteLine(s.Length <= 4 ? s.ToUpper() : s.Substring(0, 4).ToLower() + s.Substring(4));
        }
    }


    }
