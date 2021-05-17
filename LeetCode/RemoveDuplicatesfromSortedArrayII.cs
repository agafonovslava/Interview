// Source : https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/ 

/**********************************************************************************
*
* 
* Follow up for "Remove Duplicates":
* What if duplicates are allowed at most twice?
* 
* 
* For example,
* Given sorted array nums = [1,1,1,2,2,3],
* 
* 
* Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3.
* It doesn't matter what you leave beyond the new length.
* 
*
**********************************************************************************/

namespace Algorithms
{
    public class Solution080
    {
        //Time complextiy : O(n)
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

