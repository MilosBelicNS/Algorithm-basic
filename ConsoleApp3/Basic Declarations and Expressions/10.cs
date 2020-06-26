using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _10
    {
        //Celzijus, Farenhajt i K
        static void Main (string [] args)
        {
            int celzijus;

            Console.Write("Enter the amount of celzius: ");
            celzijus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0} stepeni", celzijus + 273);
            Console.WriteLine("Farenhajt = {0} stepeni", celzijus * 18 / 10 + 32);
            Console.ReadKey();

        }
    }
}
