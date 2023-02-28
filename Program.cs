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
            String[] arr = {  "Barela", "Subhash","zara", "Akash", "Ritesh", "Rajesh" };

            InsertionSort obj =new InsertionSort();
            obj.sort_sub(arr);
            Console.ReadLine();
          
           
        }

       
    }

    
}





