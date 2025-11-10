using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Arrays
{

    // Example: nums=[1,1,1,2,2,3], k=2 → [1,2]
    internal class Top_K_Frequent_Elements
    {
        public static int[] TopKFrequentElements(int[] nums)
        {
            Dictionary<int,int> dict  = new Dictionary<int, int> ();
            foreach(int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                     dict[num]++;

                }
                else
                {
                    dict.Add(num, 1);
                }
            }
           return dict.OrderByDescending(x=>x.Value).Take(2).Select(x=>x.Key).ToArray();
        }
    }
}
