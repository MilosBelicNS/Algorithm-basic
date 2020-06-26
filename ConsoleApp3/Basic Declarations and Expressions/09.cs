using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _9
    {
        static void Main (string [] args)
        {
            int a;

            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0}",a);
            Console.WriteLine(" {0}{0}", a);
            Console.WriteLine(" {0}{0}", a);
            Console.WriteLine(" {0}{0}", a);
            Console.WriteLine("{0} {0} {0}", a);
            Console.ReadKey();

        }
    }
}
