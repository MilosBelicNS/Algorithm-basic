using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _15
    {


        //Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        static void Main (string [] args)
        {
            Console.WriteLine("Input integer a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input integer b: ");
            int b = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine(SumTriple(a, b));
            //drugi nacin bez inputa bi isao ovako:
            //Console.WriteLine(SumTriple(12, 10)); 
            //Console.WriteLine(SumTriple(-5, 2));

            Console.ReadKey();

        }

        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b; 
            //ako je a==b vrati mi sumu a i b uvecanu tri puta, ako nisu jednaki vrati mi samo sumu a i b
        }
    }
}
