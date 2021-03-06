// #29 : https://leetcode.com/problems/divide-two-integers/ 
/**********************************************************************************
* Divide two ints without using multiplication, division and mod operator.
* If it is overflow, return MAX_INT.
*Example 1:
Input: dividend = 10, divisor = 3
Output: 3
Explanation: 10/3 = truncate(3.33333..) = 3.
Example 2:
Input: dividend = 7, divisor = -3
Output: -2
Explanation: 7/-3 = truncate(-2.33333..) = -2.
Example 3:
Input: dividend = 0, divisor = 1
Output: 0
Example 4:
Input: dividend = 1, divisor = 1
Output: 1
Constraints:
-2^31 <= dividend, divisor <= 2^31 - 1
divisor != 0
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution029
    {
        public static int Divide(int dividend, int divisor)
        {
            //handle special cases
            if (divisor == 0)
                return int.MaxValue;
            if (divisor == -1 && dividend == int.MinValue)
                return int.MaxValue;

            //get positive values
            long pDividend = Math.Abs((long)dividend);
            long pDivisor = Math.Abs((long)divisor);

            int result = 0;
            while (pDividend >= pDivisor)
            {
                //calculate number of left shifts
                int numShift = 0;
                while (pDividend >= (pDivisor << numShift))
                {
                    numShift++;
                }

                //dividend minus the largest shifted divisor
                result += 1 << (numShift - 1);
                pDividend -= (pDivisor << (numShift - 1));
            }

            if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}

