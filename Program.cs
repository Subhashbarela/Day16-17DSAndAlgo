using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
                        string[] arr = {"ABC", "XYZ",
                "JKL", "DEF", "MNO"};

            Console.WriteLine("Original array");
            foreach (string g in arr)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("\nAfter Sort");

          
            Array.Sort(arr);

            foreach (string g in arr)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("\nBinarySearch for 'GHI':");

           
            int index = Array.BinarySearch(arr, "GHI");

          BinarySearch<String>. sort(arr, index);

        }

       
       
    }
}





