using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _11
    //Write a C# program remove specified a character from a non-empty string using index of a character
    {
        static void Main (string [] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 7));//broj sedam odredjuje poziciju odakle ce biti izbrisan char
            Console.WriteLine(remove_char("w3resource", 0));
            Console.ReadKey();

        }

        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 2);
            //vrati mi string kod kog ce od n-te pozicije biti izbrisano 2 elementa(chara)
        }
    }
}
