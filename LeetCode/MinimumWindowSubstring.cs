// #76 : https://leetcode.com/problems/minimum-window-substring/ 
/**********************************************************************************
* Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
* For example,
* S = "ADOBECODEBANC"
* T = "ABC"
* Minimum window is "BANC".
* Note:
* If there is no such window in S that covers all characters in T, return the empty string "".
* If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
* Example 1:
Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Example 2:
Input: s = "a", t = "a"
Output: "a"
Constraints:
m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of English letters.
Follow up: Could you find an algorithm that runs in O(m + n) time?
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution076
    {
        public static string MinWindow(string s, string t)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);
            }

            int left = 0, right = 0, minlen = s.Length + 1, counter = dic.Count;
            string res = "";

            while (right < s.Length)
            {
                char rightChar = s[right];
                if (dic.ContainsKey(rightChar))
                {
                    dic[rightChar]--;
                    if (dic[rightChar] == 0)
                        counter--;
                }
                right++;

                while (counter == 0)
                {
                    if (right - left < minlen)
                    {
                        minlen = right - left;
                        res = s.Substring(left, minlen);
                    }
                    char leftChar = s[left];
                    if (dic.ContainsKey(leftChar))
                    {
                        dic[leftChar]++;
                        if (dic[leftChar] > 0)
                            counter++;
                    }
                    left++;
                }
            }

            return res;
        }
    }
}

