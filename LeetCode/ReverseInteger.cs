// #7 : https://leetcode.com/problems/reverse-integer/ 
/***************************************************************************************
* Reverse digits of an integer.
* Example1: x = 123, return 321
* Example2: x = -123, return -321 
* Have you thought about this? 
* Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!
* If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.
* Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?
* For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
* Update (2014-11-10):
* Test cases had been added to test the overflow behavior. 
Example 1:
Input: x = 123
Output: 321
Example 2:
Input: x = -123
Output: -321
Example 3:
Input: x = 120
Output: 21
Example 4:
Input: x = 0
Output: 0
Constraints:
-231 <= x <= 231 - 1
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution007
    {
        public static int Reverse(int x)
        {
            if (x <= int.MinValue || x >= int.MaxValue)
            {
                return 0;
            }
            var integer = Math.Abs(x);
            var result = 0;
            while (integer != 0)
            {
                if (result > (int.MaxValue - integer % 10) / 10)
                {
                    return 0;
                }
                result = result * 10 + integer % 10;
                integer /= 10;
            }

            return x > 0 ? result : -result;
        }
    }
}

