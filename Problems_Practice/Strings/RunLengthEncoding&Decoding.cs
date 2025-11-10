using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class RunLengthEncoding_Decoding
    {
        //    ("AAAABBBCCDAA") → "4A3B2C1D2A"

        public static string StringEncoding(string str)
        {
            if (string.IsNullOrEmpty(str))

                return string.Empty;
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(str[i]);
                    count = 1;
                }
                sb.Append(count);
                sb.Append(str[str.Length - 1]);
                
            }
            return sb.ToString();
        }
    }
}
