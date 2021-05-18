// #3 : https://leetcode.com/problems/longest-substring-without-repeating-characters/

/********************************************************************************** 
* Given a string, find the length of the longest substring without repeating characters.
* Examples:
* Given "abcabcbb", the answer is "abc", which the length is 3.
* Given "bbbbb", the answer is "b", with the length of 1.
* Given "pwwkew", the answer is "wke", with the length of 3. 
* Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
* Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
Example 4:
Input: s = ""
Output: 0
Constraints:
0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
**********************************************************************************/
using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution003
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var n = s.Length;
            var charSet = new HashSet<char>();
            int maxLength = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                if (charSet.Add(s[j]))
                {
                    j++;
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    charSet.Remove(s[i]);
                    i++;
                }
            }
            return maxLength;
        }
    }
}
