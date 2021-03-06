// #83 : https://leetcode.com/problems/remove-duplicates-from-sorted-list/ 
/**********************************************************************************
* Given a sorted linked list, delete all duplicates such that each element appear only once.
* For example,
* Given 1->1->2, return 1->2.
* Given 1->1->2->3->3, return 1->2->3.
Example 1:
Input: head = [1,1,2]
Output: [1,2]
Example 2:
Input: head = [1,1,2,3,3]
Output: [1,2,3]
Constraints:
The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { throw new NotImplementedException("TODO");val = x; }
     * }
     */
    public class Solution083
    {
        public static ListNode<int> DeleteDuplicates(ListNode<int> head)
        {
            var current = head;
            while (current != null && current.Next != null)
            {
                if (current.Next.Val == current.Val)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
            return head;
        }
    }
}

