// #43 : https://leetcode.com/problems/multiply-strings/ 
/**********************************************************************************
* Given two numbers represented as strings, return multiplication of the numbers as a string.
* Note:
* The numbers can be arbitrarily large and are non-negative.
* Converting the input string to integer is NOT allowed.
* You should NOT use internal library such as BigInteger.
Example 1:
Input: num1 = "2", num2 = "3"
Output: "6"
Example 2:
Input: num1 = "123", num2 = "456"
Output: "56088"
Constraints:
1 <= num1.length, num2.length <= 200
num1 and num2 consist of digits only.
Both num1 and num2 do not contain any leading zero, except the number 0 itself.
**********************************************************************************/

using System;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Solution043
    {
        public static string Multiply(string num1, string num2)
        {
            if (num1 == null || num2 == null || num1.Length == 0 || num2.Length == 0)
                return "";
            if (num1[0] == '0')
                return "0";
            if (num2[0] == '0')
                return "0";
            StringBuilder res = new StringBuilder();
            int num = 0;
            for (int i = num1.Length + num2.Length; i > 0; i--)
            {
                for (int j = Math.Min(i - 1, num1.Length); j > 0; j--)
                {
                    if (i - j <= num2.Length)
                    {
                        num += (num1[j - 1] - '0') * (num2[i - 1 - j] - '0');
                    }
                }
                if (i != 1 || num > 0)
                    res.Append(num % 10);
                num = num / 10;
            }

            return new string(res.ToString().Reverse().ToArray());
        }
    }
}

