// #31 : https://leetcode.com/problems/next-permutation/ 
/**********************************************************************************
* Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
* If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
* The replacement must be in-place, do not allocate extra memory.
* Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
* 1,2,3 → 1,3,2
* 3,2,1 → 1,2,3
* 1,1,5 → 1,5,1
Example 1:
Input: nums = [1,2,3]
Output: [1,3,2]
Example 2:
Input: nums = [3,2,1]
Output: [1,2,3]
Example 3:
Input: nums = [1,1,5]
Output: [1,5,1]
Example 4:
Input: nums = [1]
Output: [1]
Constraints:
1 <= nums.length <= 100
0 <= nums[i] <= 100
**********************************************************************************/

namespace Algorithms
{
    public class Solution031
    {
        public static int[] NextPermutation(int[] nums)
        {
            // find the last adjacent two element that is in ascending order
            int i = nums.Length - 1;
            while (i > 0 && nums[i - 1] >= nums[i])
            {
                i--;
            }

            // if the sequence is already in descending order, reverse the whole sequence
            if (i == 0)
            {
                reverse(nums, 0, nums.Length - 1);
                return nums;
            }

            // find the last element that is larger than nums[i-1]
            int j = nums.Length - 1;
            while (j >= i && nums[i - 1] >= nums[j])
            {
                j--;
            }

            // exchange nums[i-1] and nums[j]
            int tmp = nums[i - 1];
            nums[i - 1] = nums[j];
            nums[j] = tmp;

            // reverse the sequence after i-1
            reverse(nums, i, nums.Length - 1);
            return nums;
        }
        private static void reverse(int[] nums, int start, int end)
        {
            int l = start;
            int r = end;
            while (l < r)
            {
                int tmp = nums[l];
                nums[l] = nums[r];
                nums[r] = tmp;
                l++;
                r--;
            }
        }
    }
}

