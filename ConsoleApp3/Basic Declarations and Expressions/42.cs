using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _42
    {

        /*Write a C# program to check if a number appears as either the first or last element 
         of an array of integers and the length is 1 or more.*/

        public static void Main (string [] args)
        {
            Console.WriteLine("\n Input an intger: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));//provera prvog i poslednjeg integera
            Console.ReadKey();
        }
    }
}
