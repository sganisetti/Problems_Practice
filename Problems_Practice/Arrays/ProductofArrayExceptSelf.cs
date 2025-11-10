using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class ProductofArrayExceptSelf
    {
        public static int[] productofArrayExceptItSelf(int[] nums)
        {
            // input 1,2,3,4
            // output 24,12,8,6
            int[] ans = new int[nums.Length];
            int ProdL = 1;
            int ProdR = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                ans[i] = ProdR;
                ProdR = ProdR * nums[i];

            }
            for(int i = 0;i<nums.Length;i++)
            {
                ans[i] = ans[i] * ProdL;
                ProdL = ProdL * nums[i];
            }
            return ans;
        }
    }
}
