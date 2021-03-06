// #69 : https://leetcode.com/problems/sqrtx/ 
/**********************************************************************************
* Implement int sqrt(int x).
* Compute and return the square root of x.
Example 1:
Input: x = 4
Output: 2
Example 2:
Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since the decimal part is truncated, 2 is returned.
Constraints:
0 <= x <= 2^31 - 1
**********************************************************************************/

namespace Algorithms
{
    public class Solution069
    {
        public static int MySqrt(int x)
        {
            long r = x;

            while (r * r > x)
                r = (r + x / r) / 2;

            return (int)r;
        }
    }
}

