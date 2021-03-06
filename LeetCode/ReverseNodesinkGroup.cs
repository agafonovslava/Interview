// #25 : https://leetcode.com/problems/reverse-nodes-in-k-group/ 
/**********************************************************************************
* Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
* If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
* You may not alter the values in the nodes, only nodes itself may be changed.
* Only constant memory is allowed.
* For example,
* Given this linked list: 1->2->3->4->5
* For k = 2, you should return: 2->1->4->3->5
* For k = 3, you should return: 3->2->1->4->5
Example 1:
Input: head = [1,2,3,4,5], k = 2
Output: [2,1,4,3,5]
Example 2:
Input: head = [1,2,3,4,5], k = 3
Output: [3,2,1,4,5]
Example 3:
Input: head = [1,2,3,4,5], k = 1
Output: [1,2,3,4,5]
Example 4:
Input: head = [1], k = 1
Output: [1]
Constraints:
The number of nodes in the list is in the range sz.
1 <= sz <= 5000
0 <= Node.val <= 1000
1 <= k <= sz
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
    public class Solution025
    {
        public static ListNode<int> ReverseKGroup(ListNode<int> head, int k)
        {
            if (head == null || k == 1)
                return head;

            var fake = new ListNode<int>(0);
            fake.Next = head;
            var prev = fake;
            int i = 0;

            var p = head;
            while (p != null)
            {
                i++;
                if (i % k == 0)
                {
                    prev = reverse(prev, p.Next);
                    p = prev.Next;
                }
                else
                {
                    p = p.Next;
                }
            }

            return fake.Next;
        }

        public static ListNode<int> reverse(ListNode<int> prev, ListNode<int> next)
        {
            var last = prev.Next;
            var curr = last.Next;

            while (curr != next)
            {
                last.Next = curr.Next;
                curr.Next = prev.Next;
                prev.Next = curr;
                curr = last.Next;
            }

            return last;
        }
    }
}

