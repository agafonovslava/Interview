// #33 : https://leetcode.com/problems/search-in-rotated-sorted-array/ 
/**********************************************************************************
* Suppose a sorted array is rotated at some pivot unknown to you beforehand.
* (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
* You are given a target value to search. If found in the array return its index, otherwise return -1.
* You may assume no duplicate exists in the array.
Example 1:
Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:
Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
Example 3:
Input: nums = [1], target = 0
Output: -1
Constraints:
1 <= nums.length <= 5000
-10^4 <= nums[i] <= 10^4
All values of nums are unique.
nums is guaranteed to be rotated at some pivot.
-10^4 <= target <= 10^4
**********************************************************************************/

namespace Algorithms
{
    public class Solution033
    {
        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (target == nums[m])
                    return m;
                if (nums[m] < nums[r])
                {
                    if (target > nums[m] && target <= nums[r])
                        l = m + 1;
                    else
                        r = m - 1;
                }
                else
                {
                    if (target >= nums[l] && target < nums[m])
                        r = m - 1;
                    else
                        l = m + 1;
                }
            }
            return -1;
        }
    }
}

