using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class GroupAnagrams
    {
        public static IList<IList<string>> GroupOfAnagrams(IList<string> anagrams)
        {
            Dictionary<string,IList<string>> data = new Dictionary<string,IList<string>>();
            foreach(string str in anagrams)
            {
                
              char[] chars =   str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                if (!data.ContainsKey(key))
                
                    data[key] = new List<string>();
                data[key].Add(str);

                
            }
            return data.Values.ToList<IList<string>>();
        }
    }
}
