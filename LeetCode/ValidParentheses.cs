// #20 : https://leetcode.com/problems/valid-parentheses/ 
/***************************************************************************************
* Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
* The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
Example 1:
Input: s = "()"
Output: true
Example 2:
Input: s = "()[]{}"
Output: true
Example 3:
Input: s = "(]"
Output: false
Example 4:
Input: s = "([)]"
Output: false
Example 5:
Input: s = "{[]}"
Output: true
Constraints:
1 <= s.length <= 10^4
s consists of parentheses only '()[]{}'.
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

