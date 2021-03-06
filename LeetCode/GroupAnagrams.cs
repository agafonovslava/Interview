// #49 : https://leetcode.com/problems/group-anagrams/
/**********************************************************************************
* Given an array of strings, group anagrams together.
* For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
* Return:
* [
*   ["ate", "eat","tea"],
*   ["nat","tan"],
*   ["bat"]
* ]
* Note: All inputs will be in lower-case.
* Example 1:
Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:
Input: strs = [""]
Output: [[""]]
Example 3:
Input: strs = ["a"]
Output: [["a"]]
Constraints:
1 <= strs.length <= 10^4
0 <= strs[i].length <= 100
strs[i] consists of lower-case English letters.
**********************************************************************************/

using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution049
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            if (strs == null || strs.Length == 0)
                return res;

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] charArr = strs[i].ToCharArray();
                Array.Sort(charArr);
                string str = new string(charArr);
                if (map.ContainsKey(str))
                {
                    map[str].Add(strs[i]);
                }
                else
                {
                    List<string> list = new List<string>
                    {
                        strs[i]
                    };
                    map.Add(str, list);
                }
            }

            foreach (var iter in map.Values)
            {
                List<string> item = iter;
                if (item.Count > 0)
                    res.Add(item);
            }

            return res;
        }
    }
}

