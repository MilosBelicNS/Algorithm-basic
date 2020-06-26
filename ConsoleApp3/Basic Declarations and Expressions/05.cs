using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _5
    {
        static void Main (string [] args)
        {
            double a, b, c, d;

            Console.Write("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            d = Convert.ToDouble(Console.ReadLine());

            double result = (a + b + c + d) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, result);
            Console.ReadKey();


        }
    }
}
