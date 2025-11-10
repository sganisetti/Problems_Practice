using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class MaxSubArray
    {
        public static int maxSubArray(int[] nums)
        {
            // input : -2,1,-3,4,-1,2,1,-5,4
            // output : 4,-1,2,1
            int sum = 0;
            int max_sum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (sum > max_sum)
                {
                    max_sum = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }

            }
            return max_sum;
        }
    }
}
