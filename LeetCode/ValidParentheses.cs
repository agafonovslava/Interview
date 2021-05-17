// Source : https://leetcode.com/problems/valid-parentheses/ 

/***************************************************************************************
*
* Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
* 
* The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
* 
*
**********************************************************************************/

using System.Collections.Generic;
namespace Algorithms
{
    public class Solution020
    {
        public static bool IsValid(string s)
        {
            if (s.Length < 2 || s.Length % 2 != 0)
            {
                return false;
            }
            var left = "([{";
            var right = ")]}";
            var st = new Stack<char>();
            foreach (var c in s)
            {
                if (left.IndexOf(c) != -1)
                {
                    st.Push(c);
                }
                else
                {
                    if (st.Count == 0 || st.Pop() != left[right.IndexOf(c)])
                    {
                        return false;
                    }
                }
            }
            return st.Count == 0;
        }
    }
}

