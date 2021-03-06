// #41 : https://leetcode.com/problems/first-missing-positive/ 
/**********************************************************************************
* Given an unsorted integer array, find the first missing positive integer.
* For example,
* Given [1,2,0] return 3,
* and [3,4,-1,1] return 2.
* Your algorithm should run in O(n) time and uses constant space.
*Example 1:
Input: nums = [1,2,0]
Output: 3
Example 2:
Input: nums = [3,4,-1,1]
Output: 2
Example 3:
Input: nums = [7,8,9,11,12]
Output: 1
Constraints:
1 <= nums.length <= 5 * 105
-2^31 <= nums[i] <= 2^31 - 1
**********************************************************************************/

namespace Algorithms
{
    public class Solution041
    {
        public static int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length;)
            {
                if (nums[i] > 0 &&
                    nums[i] <= nums.Length &&
                    nums[nums[i] - 1] != nums[i])
                {
                    Swap(ref nums[i], ref nums[nums[i] - 1]);
                }
                else
                {
                    i++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}

