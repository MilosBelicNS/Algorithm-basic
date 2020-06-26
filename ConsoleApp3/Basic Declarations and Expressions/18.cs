using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _18
    {
        //Write a C# program to check if an given integer is within 20 of 100 or 200.
        //da li je int u razmaku od 20 kod brojeva 100 i 200
        public static void Main(string [] args)
        {
            Console.WriteLine("\nInput an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
            Console.ReadKey();

        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }
}
