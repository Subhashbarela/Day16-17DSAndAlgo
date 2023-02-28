using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    internal class AnagramProgram
    {
        public void anagram()
        {
            //night = thing
           //below=elbow
            //study = dusty.
            string str1 = "debit card";
            string str2 = "bad credit";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("The strings are Anagrams");
            }
            else
            {
                Console.WriteLine("The strings are not Anagrams");

            }
        }
    }
}
