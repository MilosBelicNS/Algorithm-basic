using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _29
    {
       /* Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor
        Sample Output:
        Input first integer:
        15
        True */
        public static void Main ()
        {
            Console.WriteLine("\n Input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if(x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
                Console.ReadKey();
            }

        }
    }
}
