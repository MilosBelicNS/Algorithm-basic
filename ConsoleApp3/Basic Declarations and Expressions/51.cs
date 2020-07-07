using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _51
    {

        //Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value.

       
        public static void Main()
        {
            Console.WriteLine(checkPalindrome("aaa"));
            Console.WriteLine(checkPalindrome("abc"));
            Console.WriteLine(checkPalindrome("madam"));
            Console.WriteLine(checkPalindrome("1234"));
            Console.ReadKey();

        }

        public static bool checkPalindrome(string inputString)
        {
            char[] c = inputString.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(inputString);
        }
    }
}
