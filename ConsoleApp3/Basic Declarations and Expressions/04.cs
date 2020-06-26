using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class Operacije_sa_jednim_Inputom
    {
        static void Main (string [] args)
        {
            int a; //moze se inicijalizovati direknto na liniji 17 ovako : int a = Convert.ToInt32(Console.ReadLine());
            int rezultat;

            Console.Write("Enter a number: ");
           a = Convert.ToInt32(Console.ReadLine());

            rezultat = a * 1;
            Console.WriteLine("Tabela : {0} * {1} = {2}", a, 1, rezultat);
            rezultat = a * 2;
            Console.WriteLine("         {0} * {1} = {2}", a, 2, rezultat);
            rezultat = a * 3;
            Console.WriteLine("         {0} * {1} = {2}", a, 3, rezultat);
            rezultat = a * 4;
            Console.WriteLine("         {0} * {1} = {2}", a, 4, rezultat);
            rezultat = a * 5;
            Console.WriteLine("         {0} * {1} = {2}", a, 5, rezultat);
            rezultat = a * 6;
            Console.WriteLine("         {0} * {1} = {2}", a, 6, rezultat);
            rezultat = a * 7;
            Console.WriteLine("         {0} * {1} = {2}", a, 7, rezultat);
            rezultat = a * 8;
            Console.WriteLine("         {0} * {1} = {2}", a, 8, rezultat);
            rezultat = a * 9;
            Console.WriteLine("         {0} * {1} = {2}", a, 9, rezultat);
            rezultat = a * 10;
            Console.WriteLine("         {0} * {1} = {2}", a, 10, rezultat);

            Console.ReadKey();



        }
    }
}
