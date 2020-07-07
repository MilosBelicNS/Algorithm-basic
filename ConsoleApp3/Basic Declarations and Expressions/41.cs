using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _41
    {
       // Write a C# program to count a specified number in a given array of integers.
       public static void Main (string [] args)
        {
            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine()); //unesi integer
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Number of " + x + " present in the said array:");
            Console.WriteLine(nums.Count(n => n == x)); //izbaci mi n koji je jednak x unetom integeru
            Console.ReadKey();
        }
    }
}
