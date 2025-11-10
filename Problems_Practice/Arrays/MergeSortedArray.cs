using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class MergeSortedArray
    {
        // input1: 1,2,3,0,0,0
        // input 2 : 2,5,6
        // output : 1,2,2,3,5,6
        public static int[] MergesortedArray(int[] nums1, int[] nums2,int m,int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (j >= 0)
            {
                if ( nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--; 
                    k--;
                }
            }
           
            return nums1;
        }
    }
}
