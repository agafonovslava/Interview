// #27 : https://leetcode.com/problems/remove-element/ 
/**********************************************************************************
* Given an array and a value, remove all instances of that value in place and return the new length.
* Do not allocate extra space for another array, you must do this in place with constant memory.
* The order of elements can be changed. It doesn't matter what you leave beyond the new length.
* Example:
* Given input array nums = [3,2,2,3], val = 3
* Your function should return length = 2, with the first two elements of nums being 2.
*   Try two pointers.
*   Did you use the property of "the order of elements can be changed"?
*   What happens when the elements to remove are rare?
Example 1:
Input: nums = [3,2,2,3], val = 3
Output: 2, nums = [2,2]
Explanation: Your function should return length = 2, with the first two elements of nums being 2.
It doesn't matter what you leave beyond the returned length. For example if you return 2 with nums = [2,2,3,3] or nums = [2,2,0,0], your answer will be accepted.
Example 2:
Input: nums = [0,1,2,2,3,0,4,2], val = 2
Output: 5, nums = [0,1,4,0,3]
Explanation: Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4. Note that the order of those five elements can be arbitrary. It doesn't matter what values are set beyond the returned length.
Constraints:
0 <= nums.length <= 100
0 <= nums[i] <= 50
0 <= val <= 100
**********************************************************************************/

namespace Algorithms
{
    public class Solution027
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0 || nums == null) return 0;
            var index = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}

