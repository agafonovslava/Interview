// #28 : https://leetcode.com/problems/implement-strstr/ 
/**********************************************************************************
* Implement strStr().
* Returns the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
Example 1:
Input: haystack = "hello", needle = "ll"
Output: 2
Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1
Example 3:
Input: haystack = "", needle = ""
Output: 0
Constraints:
0 <= haystack.length, needle.length <= 5 * 10^4
haystack and needle consist of only lower-case English characters.
**********************************************************************************/

namespace Algorithms
{
    public class Solution028
    {
        public static int StrStr(string haystack, string needle)
        {
            int i, j;
            for (i = j = 0; i < haystack.Length && j < needle.Length;)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i -= j - 1;
                    j = 0;
                }
            }

            return j != needle.Length ? -1 : i - j;
        }
    }
}

