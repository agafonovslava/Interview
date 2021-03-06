// #80 : https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/ 
/**********************************************************************************
* Follow up for "Remove Duplicates":
* What if duplicates are allowed at most twice?
* For example,
* Given sorted array nums = [1,1,1,2,2,3],
* Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3.
* It doesn't matter what you leave beyond the new length.
Example 1:
Input: nums = [1,1,1,2,2,3]
Output: 5, nums = [1,1,2,2,3]
Explanation: Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively. It doesn't matter what you leave beyond the returned length.
Example 2:
Input: nums = [0,0,1,1,1,1,2,3,3]
Output: 7, nums = [0,0,1,1,2,3,3]
Explanation: Your function should return length = 7, with the first seven elements of nums being modified to 0, 0, 1, 1, 2, 3 and 3 respectively. It doesn't matter what values are set beyond the returned length.
Constraints:
1 <= nums.length <= 3 * 10^4
-10^4 <= nums[i] <= 10^4
nums is sorted in ascending order.
**********************************************************************************/

namespace Algorithms
{
    public class Solution080
    {
        //Time complexity : O(n)
        //Assume that n is the length of array.Each of i and j traverses at most n steps.
        //Space complexity : O(1)
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length < 3)
                return nums.Length;

            int s = 2;
            for (int f = s; f < nums.Length; f++)
            {
                if (nums[f] != nums[s - 2])
                {
                    nums[s++] = nums[f];
                }
            }

            return s;
        }
    }
}

