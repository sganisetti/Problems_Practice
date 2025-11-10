using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_Practice.Strings
{
    internal class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            //string input1 = "([{}])";
            // "([)]"
            foreach (char ch in s)
            {
                // Push opening brackets
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else
                {
                    // If closing bracket but stack is empty → invalid
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    // Check for matching pair
                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            // At the end, stack should be empty
            return stack.Count == 0;
        }

        
        public static bool IsValid3(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "")
                     .Replace("{}", "")
                     .Replace("[]", "");
            }

            return s.Length == 0;
        }
    }
}
