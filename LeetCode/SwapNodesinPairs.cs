// #24 : https://leetcode.com/problems/swap-nodes-in-pairs/ 
/**********************************************************************************
* Given a linked list, swap every two adjacent nodes and return its head.
* For example,
* Given 1->2->3->4, you should return the list as 2->1->4->3.
* Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
Example 2:
Input: head = []
Output: []
Example 3:
Input: head = [1]
Output: [1]
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
    public class Solution024
    {
        public static ListNode<int> SwapPairs(ListNode<int> head)
        {
            var dummy = new ListNode<int>(0);
            dummy.Next = head;
            head = dummy;
            while (head.Next != null && head.Next.Next != null)
            {
                var tail = head.Next;
                var nextHead = head.Next.Next;
                head.Next = nextHead;
                tail.Next = nextHead.Next;
                nextHead.Next = tail;
                head = tail;
            }

            return dummy.Next;
        }

    }
}

