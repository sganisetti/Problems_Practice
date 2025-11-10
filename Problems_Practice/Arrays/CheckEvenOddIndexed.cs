using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems_Practice.Arrays
{
    internal class CheckEvenOddIndexed
    {

//        Question: Given an array, find out if all odd indexed elements are odd numbers and all even indexed elements are even numbers in a single pass through the array.

//Example 1:
//Input: nums = [2, 1, 4, 3]
//Output: True
//Explanation: Even indexed elements (0, 2) and are even numbers(2, 4); odd indexed elements(1, 3) are odd numbers(1, 3).

//Example 2:
//Input: nums = [2, 4, 6, 8]
//Output: False
//Explanation: Not all odd indexed elements are odd numbers.


        public static bool CheckEvenOddIndexexd(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                // even index should have even number
                if (i % 2 == 0 && nums[i] % 2 != 0)
                    return false;

                // odd index should have odd number
                if (i % 2 != 0 && nums[i] % 2 == 0)
                    return false;
            }

            return true; // all passed
        }
    }
}
