// #61 : https://leetcode.com/problems/rotate-list/ 
/**********************************************************************************
* Given a list, rotate the list to the right by k places, where k is non-negative.
* For example:
* Given 1.2.3.4.5.null and k = 2,
* return 4.5.1.2.3.null.
Example 1:
Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:
Input: head = [0,1,2], k = 4
Output: [2,0,1]
Constraints:
The number of nodes in the list is in the range [0, 500].
-100 <= Node.val <= 100
0 <= k <= 2 * 109
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class Solution061
    {
        public static ListNode<int> RotateRight(ListNode<int> head, int k)
        {
            if (head == null || k == 0)
                return head;
            int len = 1;
            var p = head;
            while (p.Next != null)
            {
                len++;
                p = p.Next;
            }
            k = len - k % len;
            p.Next = head;
            for (int step = 0; step < k; step++)
            {
                p = p.Next;
            }
            head = p.Next;
            p.Next = null;
            return head;
        }
    }

}

