using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Dictionarys
{
    internal class Dict
    {

        public static void Dictionary()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 1);
            dict.Add(2, 1);
            dict.Add(3, 1);

            int[] nums = { 1, 4, 5 };
            foreach (int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                 bool flag =   dict.TryGetValue(2, out int value);
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (KeyValuePair<int, int> data in dict)
            {
                if(data.Value >= 2)
                {
                    Console.WriteLine(data.Value);
                }
            }



        }
    }
}
