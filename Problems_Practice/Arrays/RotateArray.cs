using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class RotateArray
    {
        // 1234567
        // 5671234

        public static int[] rotate(int[] nums1,int k)
        {
            int Len = nums1.Length;
            Reverse(nums1, 0, Len - 1);
            Reverse(nums1, 0, k - 1);
            Reverse(nums1, k, Len - 1);
            return nums1;
        }
        public static void Reverse(int[] nums,int start,int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
