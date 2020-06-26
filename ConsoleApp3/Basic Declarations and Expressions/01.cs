using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class Swap_Numbers_with_Inputs
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("\nInput the First Number : ");
            a = int.Parse(Console.ReadLine());


            Console.Write("\nInput the Second Number : ");
            b = int.Parse(Console.ReadLine());



            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.ReadKey();



        }
    }
}
