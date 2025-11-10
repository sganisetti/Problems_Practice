using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{
    internal class FindDuplicateInArray
    {
        public static int FindDuplicateInArrayy(int[] nums)
        {
            Dictionary<int,int> dups = new Dictionary<int,int>();

            foreach(int num in nums)
            {
                if (dups.ContainsKey(num))
                {
                    dups[num]++;
                    return num;
                }
                else
                {
                    dups[num] = 1;
                }
            }
            foreach(var dup in dups)
            {
                if(dup.Value > 1)
                {
                    Console.WriteLine(dup.Key);
                }
            }
            return -1;
        }
    }
}
