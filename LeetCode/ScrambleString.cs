// #87 : https://leetcode.com/problems/scramble-string/ 
/**********************************************************************************
* Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.
* Below is one possible representation of s1 = "great":
*     great
*    /    \
*   gr    eat
*  / \    /  \
* g   r  e   at
*            / \
*           a   t
* To scramble the string, we may choose any non-leaf node and swap its two children.
* For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".
*     rgeat
*    /    \
*   rg    eat
*  / \    /  \
* r   g  e   at
*            / \
*           a   t
* We say that "rgeat" is a scrambled string of "great".
* Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".
*     rgtae
*    /    \
*   rg    tae
*  / \    /  \
* r   g  ta  e
*        / \
*       t   a
* 
* 
* We say that "rgtae" is a scrambled string of "great".
* Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.
Example 1:
Input: s1 = "great", s2 = "rgeat"
Output: true
Explanation: One possible scenario applied on s1 is:
"great" --> "gr/eat" // divide at random index.
"gr/eat" --> "gr/eat" // random decision is not to swap the two substrings and keep them in order.
"gr/eat" --> "g/r / e/at" // apply the same algorithm recursively on both substrings. divide at ranom index each of them.
"g/r / e/at" --> "r/g / e/at" // random decision was to swap the first substring and to keep the second substring in the same order.
"r/g / e/at" --> "r/g / e/ a/t" // again apply the algorithm recursively, divide "at" to "a/t".
"r/g / e/ a/t" --> "r/g / e/ a/t" // random decision is to keep both substrings in the same order.
The algorithm stops now and the result string is "rgeat" which is s2.
As there is one possible scenario that led s1 to be scrambled to s2, we return true.
Example 2:
Input: s1 = "abcde", s2 = "caebd"
Output: false
Example 3:
Input: s1 = "a", s2 = "a"
Output: true
Constraints:
s1.length == s2.length
1 <= s1.length <= 30
s1 and s2 consist of lower-case English letters.
*
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution087
    {
        // Time = Space = O(n^2), n = length of str1
        public static bool IsScramble(string str1, string str2)
        {
            return TryScramble(str1, str2, new Dictionary<string, bool>());
        }

        private static bool TryScramble(string s1, string s2, Dictionary<string, bool> cache)
        {
            if (s1 == s2) return true;
            string key = s1 + "+" + s2;
            if (cache.ContainsKey(key)) return cache[key];

            int n = s1.Length;
            int[] map = new int[26];
            // additional step to check the distinct characters & their frequency match, before making recursive calls
            for (int i = 0; i < n; i++)
            {
                map[s1[i] - 'a']++;
                map[s2[i] - 'a']--;
            }
            // check if frequency is not zero return false
            for (int i = 0; i < map.Length; i++)
                if (map[i] != 0)
                    return cache[key] = false;

            // Main Step, try breaking equal length s1 & s2 at each possible idx to check if any combination yields true
            for (int i = 1; i < n; i++)
                // if A+X forms 's1'
                // &  B+Y forms 's2'
                // than we return true if either
                // A,B & X,Y are scramble || A,Y & X,B are scramble
                if ((TryScramble(s1.Substring(0, i), s2.Substring(0, i), cache) && TryScramble(s1.Substring(i), s2.Substring(i), cache))
                || (TryScramble(s1.Substring(0, i), s2.Substring(n - i), cache) && TryScramble(s1.Substring(i), s2.Substring(0, n - i), cache)))
                    return cache[key] = true;

            return cache[key] = false;
        }
    }
}

