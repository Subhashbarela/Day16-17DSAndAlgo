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
            Console.WriteLine("Enter the range as you want to print prime number :");
           
            int range=Convert.ToInt32(Console.ReadLine());
            Prime obj= new Prime();
           
            obj.primeFactor(range);

      

        Console.Read();
           
             
        }

       
    }

    
}





