using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _26
    {
         //Write a C# program to convert a hexadecimal number to decimal number. Go to the editor
         //  Sample Output:
         //  Hexadecimal number: 4B0
         //  Convert to-
         //  Decimal number: 1200
        public static void Main ()
        {
            string hexval = " 4B0";
            Console.WriteLine("Hexadecimal number:  " + hexval);
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to - ");
            Console.WriteLine("Decimal number: " + decValue);
            Console.ReadKey();

        }
    }
}
