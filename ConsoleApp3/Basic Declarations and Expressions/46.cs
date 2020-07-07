using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _46
    {
        //Write a C# program to rotate the elements an array (length 3) of integers in left direction.

        public static void Main (string [] args)
        {
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("\n Array1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++) //posto krece sa nulte pozicije ici cemo do duzine niza - 1, da ne bi broj iteracija presao broj elemenata niza
            {
                nums[i] = nums[i + 1]; //prethodni element niza dobija vrednost sledeceg u nizu 
            }
            nums[nums.Length - 1] = temp; //poslednjem elementu niza dajemo vrednost prvog elementa
            Console.WriteLine("\n After rotating array becomes: [{0}]", string.Join(", ", nums));
            Console.ReadKey();

            //drugi nacin 
            //int[] array = { 1, 2, 8 };

            //Console.Write("Array[" + array[1] + ", " + array[2] + ", " + array[0] + "]");

            //Console.Read();

            //treci nacin
            //int[] nums = { 1, 2, 8 };

            //for (int i = 1; i < nums.Length; i++)

            //Console.Write("{0}, ", nums[i]);
            //Console.Write("{0}", nums[0]);
            //Console.ReadKey();
        }
    }
}
