// #9 : https://leetcode.com/problems/palindrome-number/ 
/***************************************************************************************
* Determine whether an integer is a palindrome. Do this without extra space.
* click to show spoilers.
* Some hints: 
* Could negative integers be palindromes? (ie, -1)
* If you are thinking of converting the integer to string, note the restriction of using extra space.
* You could also try reversing an integer. However, if you have solved the problem "Reverse Integer", you know that the reversed integer might overflow. How would you handle such case?
* There is a more generic way of solving this problem.
* Subscribe to see which companies asked this question
* Show Tags
Example 1:
Input: x = 121
Output: true
Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
Example 4:
Input: x = -101
Output: false
Constraints:
-2^31 <= x <= 2^31 - 1
**********************************************************************************/

using System;
namespace Algorithms
{
    public class Solution009
    {
        public static bool IsPalindromeFast(int x)
        {
            if (x < 0 || x == int.MaxValue)
            {
                return false;
            }
            if (x == 0)
            {
                return true;
            }
            var temp = 1;
            while (x / temp >= 10)
            {
                temp *= 10;
            }
            while (x > 0)
            {
                var left = x / temp;
                var right = x % 10;
                if (left != right)
                {
                    return false;
                }
                x -= temp * left;
                temp /= 100;
                x /= 10;
            }
            return true;
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0 || x >= int.MaxValue)
            {
                return false;
            }
            if (x == 0)
            {
                return true;
            }
            var maxLevel = 0;
            var temp = x;
            while (temp > 0)
            {
                temp /= 10;
                maxLevel++;
            }
            for (var i = 1; i < maxLevel / 2 + 1; i++)
            {
                var left = GetDigitNumber(i, x);
                var right = GetDigitNumber(maxLevel + 1 - i, x);
                if (left != right)
                {
                    return false;
                }
            }
            return true;
        }

        private static int GetDigitNumber(int digit, int x)
        {
            return (int)((x / Math.Pow(10, digit - 1)) % 10);
        }
    }
}

