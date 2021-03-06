// #12 : https://leetcode.com/problems/integer-to-roman/ 
/***************************************************************************************
* Given an integer, convert it to a roman numeral.
* Input is guaranteed to be within the range from 1 to 3999.
Example 1:
Input: num = 3
Output: "III"
Example 2:
Input: num = 4
Output: "IV"
Example 3:
Input: num = 9
Output: "IX"
Example 4:
Input: num = 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Example 5:
Input: num = 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
**********************************************************************************/

using System.Text;
namespace Algorithms
{
    public class Solution012
    {
        public static string IntToRoman(int num)
        {
            if (num < 0 || num > 3999)
            {
                return "";
            }
            string str = "";
            string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] value = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            for (int i = 0; num != 0; i++)
            {
                while (num >= value[i])
                {
                    num -= value[i];
                    str += symbol[i];
                }
            }
            return str;

        }
        public static string IntToRoman2(int num)
        {
            char[] symbol = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            StringBuilder roman = new StringBuilder();
            int scale = 1000;
            int p = 6;
            while (num > 0)
            {
                int digit = num / scale;
                if (digit > 0 && digit < 10)
                {
                    roman.Append(RomanStr(digit, symbol, p));
                }
                num = num % scale;
                scale /= 10;
                p -= 2;
            }
            return roman.ToString();
        }

        private static string RomanStr(int digit, char[] symbol, int p)
        {
            StringBuilder roman = new StringBuilder();
            if (digit <= 3) roman.Append(symbol[p], digit);
            else if (digit == 4)
            {
                roman.Append(symbol[p]);
                roman.Append(symbol[p + 1]);
            }
            else if (digit <= 8)
            {
                roman.Append(symbol[p + 1]);
                roman.Append(symbol[p], digit - 5);
            }
            else if (digit == 9)
            {
                roman.Append(symbol[p]);
                roman.Append(symbol[p + 2]);
            }
            return roman.ToString();
        }
    }
}

