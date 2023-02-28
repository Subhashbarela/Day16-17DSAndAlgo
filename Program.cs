using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    public class Parmutation
    {
        private static void permute(String str, int startpt, int rangeOfStr)
        {
            if (startpt == rangeOfStr)
                Console.WriteLine(str);
            else
            {
                for (int i = startpt; i <= rangeOfStr; i++)
                {
                    str = swap(str, startpt, i);
                    permute(str, startpt + 1, rangeOfStr);
                    str = swap(str, startpt, i);
                }
            }
        }
        public static String swap(String str,int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Parmutation p = new Parmutation();
                String str = "ABC";
                int n = str.Length;
                permute(str, 0, n - 1);

            }
        }
    }
}
