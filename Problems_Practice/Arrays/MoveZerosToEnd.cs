using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class MoveZerosToEnd
    {
        //1, 0, 3, 0, 2
        public static int[] Move_Zeros_To_End(int[] nums)
        {
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[counter] = nums[i];
                    counter++;

                }
            }
            while(counter < nums.Length)
            {
                nums[counter] = 0;
                counter++;
                
            }

            return nums;
        }
    }
}
