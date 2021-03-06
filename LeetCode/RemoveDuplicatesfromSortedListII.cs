// #82 : https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/ 
/**********************************************************************************
* Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
* For example,
* Given 1->2->3->3->4->4->5, return 1->2->5.
* Given 1->1->1->2->3, return 2->3.
Example 1:
Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:
Input: head = [1,1,1,2,3]
Output: [2,3]
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
    public class Solution082
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/solution/
        /// </summary>
        public static ListNode<int> DeleteDuplicates(ListNode<int> head)
        {
            var sentinel = new ListNode<int>(0);
            sentinel.Next = head;

            // predecessor = the last node before the sublist of duplicates
            var pred = sentinel;

            while (head != null)
            {
                // if it's a beginning of duplicates sublist skip all duplicates
                if (head.Next != null && head.Val == head.Next.Val)
                {
                    // move till the end of duplicates sublist
                    while (head.Next != null && head.Val == head.Next.Val)
                    {
                        head = head.Next;
                    }
                    // skip all duplicates
                    pred.Next = head.Next;
                }
                else
                {
                    // otherwise, move predecessor
                    pred = pred.Next;
                }

                // move forward
                head = head.Next;
            }
            return sentinel.Next;
        }
    }
}

