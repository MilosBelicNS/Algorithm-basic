using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _6
    {
        static void Main(string[] args)
        {
            int a, b, c;


            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1}, {2}, (a+b)*c is {3} and a*b + b*c is {4}\n\n",
                a, b, c, ((a+b)*c), (a*b + b*c));
            Console.ReadKey();



        }
    }
}
