// #66 : https://leetcode.com/problems/plus-one/ 
/**********************************************************************************
* Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
* You may assume the integer do not contain any leading zero, except the number 0 itself.
* The digits are stored such that the most significant digit is at the head of the list.
Example 1:
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Example 2:
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Example 3:
Input: digits = [0]
Output: [1]
Constraints:
1 <= digits.length <= 100
0 <= digits[i] <= 9
**********************************************************************************/

namespace Algorithms
{
    public class Solution066
    {
        public static int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return digits;

            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = (digits[i] + carry) % 10;
                carry = (digits[i] + carry) / 10;
                digits[i] = digit;
                if (carry == 0)
                    return digits;
            }

            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            return res;
        }
    }
}

