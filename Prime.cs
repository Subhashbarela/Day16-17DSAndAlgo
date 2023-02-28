using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    internal class Prime
    {
        public void displayPrimePalindrome(int range)
        {

            int count = 0;

            for (int i = 100; i <= range; i++)
            {

                int num = i, revNum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    revNum = revNum * 10 + digit;
                }


                if (revNum == i)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i + " ");
                        count++;
                        if (count == 10)
                        {
                            Console.WriteLine();
                            count = 0;
                        }
                    }
                }
            }

        }
    }
}
