using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _32
    {
        //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. Go to the editor
        //Sample Output:
        //Input a first number: -5
        //Input a second number: 8
        //True

        public static void Main()
        {
            Console.Write("Input a first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(((a >= -10 && a <= 10)) || ((b >= -10 && a <= b)));
            Console.ReadKey();
        }
    }
}
