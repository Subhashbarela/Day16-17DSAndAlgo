using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{

    public  class Program
    {
        public static void Main(string[] args) 
        {
            int []a = { 12, 31, 25, 8, 32, 17, 40, 42 };
            int n = a.Length;
            MergeSorting obj=new MergeSorting();
            Console.WriteLine("Before sorting array elements are : \n");
            obj.printArray(a, n);
            obj.mergeSort(a, 0, n - 1);
            Console.WriteLine("\n\nAfter sorting array elements are :\n");
            obj.printArray(a, n);
            Console.Read();
            return;
             
        }

       
    }

    
}





