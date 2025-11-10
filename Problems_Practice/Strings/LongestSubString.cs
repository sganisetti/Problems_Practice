using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class LongestSubString
    {
        public static int Longest_SubString(string str)
        {
            // Example: "abcabcbb" → 3 ("abc")
            //sliding window
            int start = 0;
            int end = 0;
            int Max_Len = 0;
            List<char> list = new List<char>();
           

            while(end < str.Length)
            {
                if (!list.Contains(str[end]))
                {
                    list.Add(str[end]);
                    end++;
                    Max_Len = Math.Max(Max_Len, list.Count);
                }
                else
                {
                    list.Remove(str[start]);
                    start++;
                }
            }
            return Max_Len;
        }
    }
}
