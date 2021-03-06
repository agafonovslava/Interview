// #91 : https://leetcode.com/problems/decode-ways 
/**********************************************************************************
* A message containing letters from A-Z is being encoded to numbers using the following mapping:
* 'A' -> 1
* 'B' -> 2
* ...
* 'Z' -> 26
* Given an encoded message containing digits, determine the total number of ways to decode it.
* For example,
* Given encoded message "12",
* it could be decoded as "AB" (1 2) or "L" (12).
* The number of ways decoding "12" is 2.
* Since the answer may be very large, return it modulo 109 + 7.
Example 1:
Input: s = "*"
Output: 9
Explanation: The encoded message can represent any of the encoded messages "1", "2", "3", "4", "5", "6", "7", "8", or "9".
Each of these can be decoded to the strings "A", "B", "C", "D", "E", "F", "G", "H", and "I" respectively.
Hence, there are a total of 9 ways to decode "*".
Example 2:
Input: s = "1*"
Output: 18
Explanation: The encoded message can represent any of the encoded messages "11", "12", "13", "14", "15", "16", "17", "18", or "19".
Each of these encoded messages have 2 ways to be decoded (e.g. "11" can be decoded to "AA" or "K").
Hence, there are a total of 9 * 2 = 18 ways to decode "1*".
Example 3:
Input: s = "2*"
Output: 15
Explanation: The encoded message can represent any of the encoded messages "21", "22", "23", "24", "25", "26", "27", "28", or "29".
"21", "22", "23", "24", "25", and "26" have 2 ways of being decoded, but "27", "28", and "29" only have 1 way.
Hence, there are a total of (6 * 2) + (3 * 1) = 12 + 3 = 15 ways to decode "2*".
**********************************************************************************/

namespace Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/decode-ways-ii/solution/
    /// </summary>
    public class Solution091
    {
        private static int M = 1000000007;
        public static int NumDecodings(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            long[] dp = new long[s.Length + 1];
            dp[0] = 1;
            dp[1] = s[0] == '*' ? 9 : s[0] == '0' ? 0 : 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    dp[i + 1] = 9 * dp[i];
                    if (s[i - 1] == '1')
                        dp[i + 1] = (dp[i + 1] + 9 * dp[i - 1]) % M;
                    else if (s[i - 1] == '2')
                        dp[i + 1] = (dp[i + 1] + 6 * dp[i - 1]) % M;
                    else if (s[i - 1] == '*')
                        dp[i + 1] = (dp[i + 1] + 15 * dp[i - 1]) % M;
                }
                else
                {
                    dp[i + 1] = s[i] != '0' ? dp[i] : 0;
                    if (s[i - 1] == '1')
                        dp[i + 1] = (dp[i + 1] + dp[i - 1]) % M;
                    else if (s[i - 1] == '2' && s[i] <= '6')
                        dp[i + 1] = (dp[i + 1] + dp[i - 1]) % M;
                    else if (s[i - 1] == '*')
                        dp[i + 1] = (dp[i + 1] + (s[i] <= '6' ? 2 : 1) * dp[i - 1]) % M;
                }
            }

            return (int)dp[s.Length];
        }
    }
}

