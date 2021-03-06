// #38 : https://leetcode.com/problems/count-and-say/ 
/**********************************************************************************
* The count-and-say sequence is the sequence of integers beginning as follows:
* 1, 11, 21, 1211, 111221, ...
* 1 is read off as "one 1" or 11.
* 11 is read off as "two 1s" or 21.
* 21 is read off as "one 2, then one 1" or 1211.
* Given an integer n, generate the nth sequence.
* Note: The sequence of integers will be represented as a string.
Example 1:
Input: n = 1
Output: "1"
Explanation: This is the base case.
Example 2:
Input: n = 4
Output: "1211"
Explanation:
countAndSay(1) = "1"
countAndSay(2) = say "1" = one 1 = "11"
countAndSay(3) = say "11" = two 1's = "21"
countAndSay(4) = say "21" = one 2 + one 1 = "12" + "11" = "1211"
Constraints:
1 <= n <= 30
**********************************************************************************/

namespace Algorithms
{
    public class Solution038
    {
        public static string CountAndSay(int n)
        {
            string s = "1";
            for (int i = 1; i < n; i++)
            {
                s = Cal(s);
            }
            return s;
        }

        static string Cal(string s)
        {
            string ans = "";
            int cnt = 1;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (i + 1 < len && s[i] != s[i + 1])
                {
                    ans = ans + cnt.ToString() + s[i];
                    cnt = 1;
                }
                else if (i + 1 < len)
                {
                    cnt++;
                }
            }
            ans = ans + cnt.ToString() + s[len - 1];

            return ans;
        }
    }
}

