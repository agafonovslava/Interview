// #60 : https://leetcode.com/problems/permutation-sequence/ 
/**********************************************************************************
* The set [1,2,3,&#8230;,n] contains a total of n! unique permutations.
* By listing and labeling all of the permutations in order,
* We get the following sequence (ie, for n = 3):
* "123"
* "132"
* "213"
* "231"
* "312"
* "321"
* Given n and k, return the kth permutation sequence.
* Note: Given n will be between 1 and 9 inclusive.
Example 1:
Input: n = 3, k = 3
Output: "213"
Example 2:
Input: n = 4, k = 9
Output: "2314"
Example 3:
Input: n = 3, k = 1
Output: "123"
Constraints:
1 <= n <= 9
1 <= k <= n!
**********************************************************************************/

namespace Algorithms
{
    public class Solution060
    {
        public static string GetPermutation(int n, int k)
        {
            int total = factorial(n);
            string candidate = ("123456789").Substring(0, n);
            string res = "";
            for (int i = 0; i < n; i++)
            {
                total /= (n - i);
                int index = (k - 1) / total;
                res += candidate[index];
                candidate = candidate.Remove(index, 1);
                k -= index * total;
            }
            return res;
        }

        static int factorial(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
        }
    }
}

