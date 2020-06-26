using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Basic_Declarations_and_Expressions
{
    class _27
    {
        //Write a C# program to multiply corresponding elements of two arrays of integers. Go to the editor
        //Sample Output:
        //Array1: [1, 3, -5, 4]
        //Array2: [1, 4, -5, -2]
        //Multiply corresponding elements of two arrays:
        //1 12 25 -8


        public static void Main()
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("\n Array1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("\n Array2: [{0}]", string.Join(", ", second_array));

            Console.WriteLine("\nMultyply corresponding elements of two arrays: ");

            for(int i = 0; i < first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");
            
            Console.ReadKey();
        }
        
    }
}
