using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _33
    {

         /* Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". Go to the editor
         Test Data: PHP Tutorial
         Sample Output:
         P Tutorial*/ 

        public static void Main (string [] args)
        {
            string str = "PPH Tutorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
            //ako su od prvog elementa sledeca dva elementa jednaka karakterima HP obrisi mi dva karakteraa i ispisi mi ostatak stringa
            //ako ne postoje karakteri HP onda mi samo vrati ceo string bez brisanja
            Console.ReadKey();
        }
    }
}
