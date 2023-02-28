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

            Prime obj = new Prime();
           
            Console.WriteLine("insert the  range :");
            int range = Convert.ToInt32(Console.ReadLine());
            obj.displayPrimePalindrome(range);

            Console.Read();

        }   
        

       
    }

    
}





