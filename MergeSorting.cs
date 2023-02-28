using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortTechnique
{
    internal class MergeSorting
    {
       public void merge(int []a, int beg, int mid, int end)
        {
            int i, j, k;
            int len1 = mid - beg + 1;
            int len2 = end - mid;

            int []LeftArr = new int[len1]; 
            int [] RightArr = new int[len2]; //temporary arrays  

           for ( i = 0; i < len1; i++)   /* copy data to temp arrays */
            {
                LeftArr[i] = a[beg + i];
            }
               
            for (j = 0; j < len2; j++)
            {
                RightArr[j] = a[mid + 1 + j];
            }
                

            i = 0;
            j = 0; 
            k = beg; 

            while (i < len1 && j < len2)
            {
                if (LeftArr[i] <= RightArr[j])
                {
                    a[k] = LeftArr[i];
                    i++;
                }
                else
                {
                    a[k] = RightArr[j];
                    j++;
                }
                k++;
            }
            while (i < len1)
            {
                a[k] = LeftArr[i];
                i++;
                k++;
            }

            while (j < len2)
            {
                a[k] = RightArr[j];
                j++;
                k++;
            }
        }
        public void mergeSort(int[] a, int beg, int end)
        {
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                mergeSort(a, beg, mid);
                mergeSort(a, mid + 1, end);
                merge(a, beg, mid, end);
            }
        }
        public void printArray(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++)
                Console.Write(a[i]+" ");
           
        }
       
    }
 }

