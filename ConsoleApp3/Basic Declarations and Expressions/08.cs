using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _8
    {
        static void Main (string [] args)
        {
            int num;


            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());


            //Part A: "num num num num" using Write
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            //Part B: "numnumnumnum" using Write
            Console.Write(num);
            
            Console.Write(num);
            
            Console.Write(num);
            
            Console.Write(num);
            Console.WriteLine();

            // Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.ReadKey();

        }
    }
}
