// #19 : https://leetcode.com/problems/remove-nth-node-from-end-of-list/ 

/***************************************************************************************
* Given a linked list, remove the nth node from the end of list and return its head.
* For example,
*    Given linked list: 1->2->3->4->5, and n = 2.
*    After removing the second node from the end, the linked list becomes 1->2->3->5.
* Note:
* Given n will always be valid.
* Try to do this in one pass.
*Example 1:
Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:
Input: head = [1], n = 1
Output: []
Example 3:
Input: head = [1,2], n = 1
Output: [1]
Constraints:
The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    public class Solution019
    {
        public static ListNode<int> RemoveNthFromEnd(ListNode<int> head, int n)
        {
            ListNode<int> start = new ListNode<int>(0)
            {
                Next = head
            };

            ListNode<int> fast = start, slow = start;
            while (n > 0)
            {
                fast = fast.Next;
                n--;
            }

            while (fast.Next != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            slow.Next = slow.Next.Next;

            return start.Next;
        }
    }
}

