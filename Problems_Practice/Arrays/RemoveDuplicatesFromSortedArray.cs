using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class RemoveDuplicatesFromSortedArray
    {
        // input 0, 0, 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, 5
        // output  0,1,2,3,4,5
        public static int Remove_Duplicates_From_Sorted_Array(int[] nums)
        {
            int counter = 0;
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1] )
                {
                    continue;
                }
                else
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }
            return counter;
        }
    }
}
