using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _35
    {
      /*  Write a C# program to find the largest and lowest values from three integer values. Go to the editor
        Test Data:
        Input first integer: 15
    
        Input second integer: 25

        Input third integer: 30
         
         Sample Output
         Largest of three: 30
         Lowest of three: 15 */

        public static void Main (string [] args)
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
            Console.ReadKey();
        }
    }
}
