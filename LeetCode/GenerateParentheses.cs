// #22 : https://leetcode.com/problems/generate-parentheses/ 
/***************************************************************************************
* Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
* For example, given n = 3, a solution set is:
* [
*   "((()))",
*   "(()())",
*   "(())()",
*   "()(())",
*   "()()()"
* ]
* 
Example 1:
Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]
Example 2:
Input: n = 1
Output: ["()"]
Constraints:
1 <= n <= 8
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution022
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            if (n <= 0)
                return result;
            GenerateParenthesis(n, n, "", result);
            return result;
        }

        private static void GenerateParenthesis(int left, int right, string item, List<string> result)
        {
            if (right < left)
                return;

            if (left == 0 && right == 0)
            {
                result.Add(item);
            }
            if (left > 0)
            {
                GenerateParenthesis(left - 1, right, item + "(", result);
            }
            if (right > 0)
            {
                GenerateParenthesis(left, right - 1, item + ")", result);
            }
        }
    }
}

