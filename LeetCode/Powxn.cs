// #50 : https://leetcode.com/problems/powx-n/ 
/**********************************************************************************
* Implement pow(x, n).
*Example 1:
Input: x = 2.00000, n = 10
Output: 1024.00000
Example 2:
Input: x = 2.10000, n = 3
Output: 9.26100
Example 3:
Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
Constraints:
-100.0 < x < 100.0
-231 <= n <= 231-1
-104 <= xn <= 104
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution050
    {
        public static double MyPow(double x, int n)
        {
            if (n == 0) return 1.0;
            var ans = 1.0;
            var i = Math.Abs(n);
            while (i > 0)
            {
                ans *= x;
                i--;
            }
            return n > 0 ? ans : 1.0 / ans;
        }

        public static double MyPow2(double x, int n)
        {
            if (n == 0) return 1.0;
            var ans = 1.0;
            if (n < 0)
            {
                if (x >= 1.0 / double.MaxValue || x <= 1.0 / -double.MaxValue)
                    x = 1.0 / x;
                else
                    return double.MaxValue;
                if (n == int.MinValue)
                {
                    ans *= x;
                    n++;
                }
            }
            n = Math.Abs(n);
            bool isNeg = false;
            if (n % 2 == 1 && x < 0)
            {
                isNeg = true;
            }

            x = Math.Abs(x);
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    if (ans > double.MaxValue / x) return double.MaxValue;
                    ans = ans * x;
                }
                x = x * x;
                n >>= 1;
            }

            return isNeg ? -ans : ans;
        }
    }
}

