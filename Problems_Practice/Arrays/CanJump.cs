using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems_Practice.Arrays
{
    internal class CanJump
    {
//        Question: You’re given an array of integers where each element represents the maximum number of steps that can be jumped going forward from that element.Write a function to determine if it is possible to reach the last index starting from the first index.

//Example 1:
//Input: nums = [2, 3, 1, 1, 4]
//Output: True
//Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index

        public static bool CanJumpp(int[] nums)
        {
            int farthest = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i > farthest)
                    return false;
                farthest = Math.Max(farthest, i+nums[i]);
                if (farthest >= nums.Length - 1)
                {
                    return true;
                }
            }

            return true;
        }
    }
}
