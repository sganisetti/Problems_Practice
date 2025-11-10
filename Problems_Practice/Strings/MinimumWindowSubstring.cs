using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            // s="ADOBECODEBANC", t="ABC" → "BANC"

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return "";

            var need = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (need.ContainsKey(c))
                    need[c]++;
                else
                    need[c] = 1;
            }

            var window = new Dictionary<char, int>();
            int have = 0, needCount = need.Count;
            int left = 0, minLen = int.MaxValue;
            int minStart = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];
                if (need.ContainsKey(c))
                {
                    if (!window.ContainsKey(c))
                        window[c] = 0;
                    window[c]++;

                    if (window[c] == need[c])
                        
                        have++;
                }

                while (have == needCount)
                {
                    // Update minimum window
                    if ((right - left + 1) < minLen)
                    {
                        minLen = right - left + 1;
                        minStart = left;
                    }

                    // Try shrinking from left
                    char leftChar = s[left];
                    if (need.ContainsKey(leftChar))
                    {
                        window[leftChar]--;
                        if (window[leftChar] < need[leftChar])
                            have--;
                    }
                    left++;
                }
            }
            Console.WriteLine(minLen);

            return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
        }

    }
}
