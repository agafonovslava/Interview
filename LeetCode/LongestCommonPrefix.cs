// #14 : https://leetcode.com/problems/longest-common-prefix/ 
/***************************************************************************************
* Write a function to find the strs[0] common prefix string amongst an array of strings.
*Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
Constraints:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
**********************************************************************************/

namespace Algorithms
{
    public class Solution014
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) 
                return "";
            var longest = "";
            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length == i || 
                        strs[j][i] != strs[0][i])
                    {
                        return longest;
                    }
                }
                longest += strs[0][i];
            }
            return longest;
        }
    }
}

