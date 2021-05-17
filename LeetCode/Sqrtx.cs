// Source : https://leetcode.com/problems/sqrtx/ 

/**********************************************************************************
*
* Implement int sqrt(int x).
* 
* Compute and return the square root of x.
*
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

