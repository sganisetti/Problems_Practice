using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class MissingNumber
    {
        // input 0,1,3
        // output 2
        public static int MissingNumberInArray(int[] nums)
        {
            int sum = 0;
            for(int i =0; i < nums.Length; i++)
            {
                sum = sum + nums[i];

            }
            int actualsum = (nums.Length *( nums.Length + 1))/ 2;
            int misssingNum = actualsum - sum;
            return misssingNum;
        }
        
    }
}
