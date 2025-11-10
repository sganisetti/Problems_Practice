using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class SearchSubString
    {
        public static int Search_SubString(string haystack , string needle)
        {
            //input :  hello ,ll 
            //Output ; 2
            if (needle.Length == 0) return 0; // Edge case

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j;
                for ( j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;
                }

                if (j == needle.Length) // Full match found
                    return i;
            }
            return -1; // Not found
        }
    }
}
