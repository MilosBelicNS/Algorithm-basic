using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _44
    {
        //Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
        public static void Main (string [] args)
        {
            
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 7, 7, 7, 8, 8, 9, 1 };
            Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));//provera duzine niza, provera jednakosti prvog i poslednjeg integera
            Console.ReadKey();


            //drugi nacin


            //int[] niz = { 3, 2, 5, 9, 8, 5, 7, 3 };
            //Console.WriteLine(niz.First().Equals(niz.Last()) && (niz.Length >= 1) ? true : false);
            //Console.ReadKey();
        }
    }
}
