// #32 : https://leetcode.com/problems/longest-valid-parentheses/ 
/**********************************************************************************
* Given a string containing just the characters '(' and ')', 
* find the length of the longest valid (well-formed) parentheses substring.
* For "(()", the longest valid parentheses substring is "()", which has length = 2.
* Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
* Example 1:
Input: s = "(()"
Output: 2
Explanation: The longest valid parentheses substring is "()".
Example 2:
Input: s = ")()())"
Output: 4
Explanation: The longest valid parentheses substring is "()()".
Example 3:
Input: s = ""
Output: 0
Constraints:
0 <= s.length <= 3 * 104
s[i] is '(', or ')'.
**********************************************************************************/

using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution032
    {
        public static int LongestValidParentheses(string s)
        {
            if (s.Length == 0) return 0;
            var result = 0;
            var dp = new List<int> { 0 };
            for (var i = 1; i <= s.Length; i++)
            {
                dp.Add(0);
                int j = i - 2 - dp[i - 1];
                if (s[i - 1] == '(' || j < 0 || s[j] == ')')
                {
                    dp[i] = 0;
                }
                else
                {
                    dp[i] = dp[i - 1] + 2 + dp[j];
                    result = Math.Max(result, dp[i]);
                }
            }

            return result;
        }
    }
}

