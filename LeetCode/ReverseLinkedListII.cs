// #92 : https://leetcode.com/problems/reverse-linked-list-ii 
/**********************************************************************************
* Reverse a linked list from position m to n. Do it in-place and in one-pass.
* For example:
* Given 1->2->3->4->5->NULL, m = 2 and n = 4,
* return 1->4->3->2->5->NULL.
* Note:
* Given m, n satisfy the following condition:
* 1 ? m ? n ? length of list.
* Example 1:
Input: head = [1,2,3,4,5], left = 2, right = 4
Output: [1,4,3,2,5]
Example 2:
Input: head = [5], left = 1, right = 1
Output: [5]
Constraints:
The number of nodes in the list is n.
1 <= n <= 500
-500 <= Node.val <= 500
1 <= left <= right <= n
Follow up: Could you do it in one pass?
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
    public class Solution092
    {
        public static ListNode<int> ReverseBetween(ListNode<int> head, int m, int n)
        {
            // Corner case
            if (head == null || head.Next == null) 
                return head;

            var dummy = new ListNode<int>(0);
            var prevTail = dummy;
            var prev = head;
            var curr = head.Next;
            dummy.Next = head;

            // Move to the m position
            int i = 1;
            for (; i < m; i++)
            {
                curr = curr.Next;
                prev = prev.Next;
                prevTail = prevTail.Next;
            }

            // Start reversing
            for (; i < n; i++)
            {
                var temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            // Connect the reversed part with the original list
            prevTail.Next.Next = curr;
            prevTail.Next = prev;

            return dummy.Next;
        }
    }
}

