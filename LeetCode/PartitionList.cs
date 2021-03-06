// #86 : https://leetcode.com/problems/partition-list/ 
/**********************************************************************************
* Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
* You should preserve the original relative order of the nodes in each of the two partitions.
* For example,
* Given 1->4->3->2->5->2 and x = 3,
* return 1->2->2->4->3->5.
Example 1:
Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:
Input: head = [2,1], x = 2
Output: [1,2]
Constraints:
The number of nodes in the list is in the range [0, 200].
-100 <= Node.val <= 100
-200 <= x <= 200
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
    public class Solution086
    {
        public static ListNode<int> Partition(ListNode<int> head, int x)
        {
            ListNode<int> first = new ListNode<int>(-1), second = new ListNode<int>(-1);
            ListNode<int> curr1 = first, curr2 = second;

            while (head != null)
            {
                if (head.Val < x)
                {
                    curr1.Next = head;
                    curr1 = head;
                }
                else
                {
                    curr2.Next = head;
                    curr2 = head;
                }

                head = head.Next;
            }

            curr2.Next = null;
            curr1.Next = second.Next;
            return first.Next;
        }
    }
}

