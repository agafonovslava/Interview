// #67 : https://leetcode.com/problems/add-binary/ 

/**********************************************************************************
* Given two binary strings, return their sum (also a binary string).
* For example,
* a = "11"
* b = "1"
* Return "100".
* Example 1:
Input: a = "11", b = "1"
Output: "100"
Example 2:
Input: a = "1010", b = "1011"
Output: "10101"
Constraints:
1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
*
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution067
    {
        public static string AddBinary(string a, string b)
        {
            char[] sum = new char[Math.Max(a.Length, b.Length) + 1];
            bool carry = false;

            if (b.Length > a.Length)
            {
                string c = a;
                a = b;
                b = c;
            }

            for (int i = a.Length - 1, j = b.Length - 1, k = sum.Length - 1; i >= 0; i--, j--, k--)
            {
                char numA = a[i];
                char numB = j >= 0 ? b[j] : '0';

                Console.WriteLine(numA + " " + numB);

                if (carry)
                {
                    sum[k] = numA == numB ? '1' : '0';
                    carry = numA == '1' || numB == '1';
                }
                else
                {
                    sum[k] = numA == numB ? '0' : '1';
                    carry = numA == '1' && numB == '1';
                }
            }

            if (carry)
            {
                sum[0] = '1';
                return new string(sum);
            }

            return new string(sum, 1, sum.Length - 1);
        }
    }
}

