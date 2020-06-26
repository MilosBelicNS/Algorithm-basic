using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class Multiply_Three_Numbers_Input
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.Write("\nInput the First Number : ");
            a = int.Parse(Console.ReadLine());


            Console.Write("\nInput the Second Number : ");
            b = int.Parse(Console.ReadLine());


            Console.Write("\nInput the Third Number : ");
            c = int.Parse(Console.ReadLine());



            int temp;

            temp = a* b*c;
          

            Console.WriteLine("Proizvod tri broja je: " + temp);
            

            Console.ReadKey();



        }
    }
}
