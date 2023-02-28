using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    public class BinarySearch<T>
    {
        public static void sort<T>(T[] array, int index)
        {
            if (index < 0)
            {

               
                index = ~index;

                Console.Write("Sorts between: ");

                if (index == 0)
                    Console.Write("beginning of array and ");
                else
                    Console.Write("{0} and ", array[index - 1]);

                if (index == array.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine("{0}.", array[index]);
            }
            else
            {
                Console.WriteLine("Found at index {0}.", index);
            }
        }
    }
}
