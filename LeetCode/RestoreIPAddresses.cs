// #93 : https://leetcode.com/problems/restore-ip-addresses 
/**********************************************************************************
* Given a string containing only digits, restore it by returning all possible valid IP address combinations.
* For example:
* Given "25525511135",
* return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
*Example 1:
Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]
Example 2:
Input: s = "0000"
Output: ["0.0.0.0"]
Example 3:
Input: s = "1111"
Output: ["1.1.1.1"]
Example 4:
Input: s = "010010"
Output: ["0.10.0.10","0.100.1.0"]
Example 5:
Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]
Constraints:
0 <= s.length <= 3000
s consists of digits only.
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution093
    {
        public static IList<string> RestoreIpAddresses(string s)
        {
            IList<string> res = new List<string>();
            int len = s.Length;
            for (int i = 1; i < 4 && i < len - 2; i++)
            {
                for (int j = i + 1; j < i + 4 && j < len - 1; j++)
                {
                    for (int k = j + 1; k < j + 4 && k < len; k++)
                    {
                        string s1 = s.Substring(0, i), s2 = s.Substring(i, j - i), s3 = s.Substring(j, k - j), s4 = s.Substring(k, len - k);
                        if (isValid(s1) && isValid(s2) && isValid(s3) && isValid(s4))
                        {
                            res.Add($"{s1}.{s2}.{s3}.{s4}");
                        }
                    }
                }
            }
            return res;
        }

        public static bool isValid(string s)
        {
            if (s.Length > 3 || s.Length == 0 || (s[0] == '0' && s.Length > 1) || int.Parse(s) > 255)
                return false;
            return true;
        }
    }
}

