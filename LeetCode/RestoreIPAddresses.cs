// Source : https://leetcode.com/problems/restore-ip-addresses 

/**********************************************************************************
*
* Given a string containing only digits, restore it by returning all possible valid IP address combinations.
* 
* 
* For example:
* Given "25525511135",
* 
* 
* return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
* 
*
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
                            res.Add(s1 + "." + s2 + "." + s3 + "." + s4);
                        }
                    }
                }
            }
            return res;
        }
        public static  bool isValid(string s)
        {
            if (s.Length > 3 || s.Length == 0 || (s[0] == '0' && s.Length > 1) || int.Parse(s) > 255)
                return false;
            return true;
        }
    }
}

