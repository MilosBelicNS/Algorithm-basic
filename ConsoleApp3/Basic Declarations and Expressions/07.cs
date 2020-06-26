using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _7
    {
        static void Main (string [] args)
        {
            Console.Write("Enter your age: ");
           int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
            Console.ReadKey();
        }
    }
}
