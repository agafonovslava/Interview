// Source : https://leetcode.com/problems/reverse-linked-list-ii 

/**********************************************************************************
*
* 
* Reverse a linked list from position m to n. Do it in-place and in one-pass.
* 
* 
* 
* For example:
* Given 1->2->3->4->5->NULL, m = 2 and n = 4,
* 
* 
* return 1->4->3->2->5->NULL.
* 
* 
* Note:
* Given m, n satisfy the following condition:
* 1 ? m ? n ? length of list.
* 
*
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
            //var dummy = new ListNode(0);

            //var prev = dummy;

            //dummy.next = head;
            //for (int i = 1; i < m; i++)
            //{
            //    prev = prev.next;
            //}

            //var pivot = prev.next;

            //for (int i = m; i < n; i++)
            //{
            //    var next = pivot.next;
            //    if (pivot.next != null)
            //    {
            //        pivot.next = pivot.next.next;
            //    }

            //    var tmp = prev.next;
            //    prev.next = next;
            //    next.next = tmp;
            //}

            //return dummy.next;

            // Corner case
            if (head == null || head.Next == null) return head;

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

