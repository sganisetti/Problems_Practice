using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class FindSubArrayWithTarget_Sum
    {
        // Example 1: Input: nums = [1, 2, 3, 7, 5], target = 12 Output: [2, 4] Explanation: The subarray nums[2] to nums[4] sums to 12, which is the target.

        public static int[] FindShortestSubarrayWithTargetSum(int[] arr, int target)
        {
            int start = 0, end = 0;
            int sum = 0;

            int minLen = int.MaxValue;
            int minStart = -1, minEnd = -1;

            while (end < arr.Length)
            {
                sum += arr[end];

                // Shrink window while sum is greater than target
                while (sum > target && start <= end)
                {
                    sum -= arr[start];
                    start++;
                }

                // Check for target sum
                if (sum == target)
                {
                    int currLen = end - start + 1;
                    if (currLen < minLen)
                    {
                        minLen = currLen;
                        minStart = start;
                        minEnd = end;
                    }
                }

                end++;
            }

            return (minStart == -1) ? new int[] { } : new int[] { minStart, minEnd };
        }

        public static int[] FindSubarrayWithTargetSum2(int[] nums, int target)
        {
            int left = 0, sum = 0;
            int minLen = int.MaxValue;
            int start = -1, end = -1;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                // Shrink window if sum exceeds target
                while (sum > target && left <= right)
                {
                    sum -= nums[left];
                    left++;
                }

                // If target sum found
                if (sum == target)
                {
                    int len = right - left + 1;
                    if (len < minLen)
                    {
                        minLen = len;
                        start = left;
                        end = right;
                    }
                }
            }

            return (start == -1) ? new int[] { } : new int[] { start, end };
        }
    }
}
