// #81 : https://leetcode.com/problems/search-in-rotated-sorted-array-ii/ 
/**********************************************************************************
* Follow up for "Search in Rotated Sorted Array":
* What if duplicates are allowed?
* Would this affect the run-time complexity? How and why?
* Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
* (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
* Write a function to determine if a given target is in the array.
* The array may contain duplicates.
Example 1:
Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true
Example 2:
Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false
Constraints:
1 <= nums.length <= 5000
-10^4 <= nums[i] <= 10^4
nums is guaranteed to be rotated at some pivot.
-10^4 <= target <= 10^4
Follow up: This problem is the same as Search in Rotated Sorted Array, where nums may contain duplicates. Would this affect the runtime complexity? How and why?
**********************************************************************************/

namespace Algorithms
{
    public class Solution081
    {
        public static bool Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 0) return false;
            int end = n - 1;
            int start = 0;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    return true;
                }

                if (!isBinarySearchHelpful(nums, start, nums[mid]))
                {
                    start++;
                    continue;
                }

                // which array does pivot belong to.
                bool pivotArray = existsInFirst(nums, start, nums[mid]);

                // which array does target belong to.
                bool targetArray = existsInFirst(nums, start, target);
                if (pivotArray ^ targetArray)
                { // If pivot and target exist in different sorted arrays, recall that xor is true when both operands are distinct
                    if (pivotArray)
                    {
                        start = mid + 1; // pivot in the first, target in the second
                    }
                    else
                    {
                        end = mid - 1; // target in the first, pivot in the second
                    }
                }
                else
                { // If pivot and target exist in same sorted array
                    if (nums[mid] < target)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return false;
        }

        // returns true if we can reduce the search space in current binary search space
        private static bool isBinarySearchHelpful(int[] arr, int start, int element)
        {
            return arr[start] != element;
        }

        // returns true if element exists in first array, false if it exists in second
        private static bool existsInFirst(int[] arr, int start, int element)
        {
            return arr[start] <= element;
        }
    }
}