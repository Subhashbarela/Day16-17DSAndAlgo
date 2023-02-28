using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    internal class Prime
    {
      public void primeFactor(int range) {
            int count;

            for (int i = 1; i <= range; i++)
            {
                count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
