// Source : https://leetcode.com/problems/rotate-list/ 

/**********************************************************************************
*
* Given a list, rotate the list to the right by k places, where k is non-negative.
* 
* For example:
* Given 1.2.3.4.5.null and k = 2,
* return 4.5.1.2.3.null.
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

