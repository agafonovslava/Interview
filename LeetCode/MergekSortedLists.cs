// #23 : https://leetcode.com/problems/merge-k-sorted-lists/ 
/**********************************************************************************
* Merge k sorted linked lists and return it as one sorted list.
* Analyze and describe its complexity.
*Example 1:
Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
  1->4->5,
  1->3->4,
  2->6
]
merging them into one sorted list:
1->1->2->3->4->4->5->6
Example 2:
Input: lists = []
Output: []
Example 3:
Input: lists = [[]]
Output: []
Constraints:
k == lists.length
0 <= k <= 10^4
0 <= lists[i].length <= 500
-10^4 <= lists[i][j] <= 10^4
lists[i] is sorted in ascending order.
The sum of lists[i].length won't exceed 10^4
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
    public class Solution023
    {
        public static ListNode<int> MergeKLists(ListNode<int>[] lists)
        {
            if (lists.Length == 0) return null;
            var right = lists.Length - 1;
            while (right > 0)
            {
                var left = 0;
                while (left < right)
                {
                    lists[left] = MergeTwoLists(lists[left], lists[right]);
                    left++;
                    right--;
                }
            }
            return lists[0];
        }

        private static ListNode<int> MergeTwoLists(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> dummy = new ListNode<int>(0);
            ListNode<int> lastNode = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.Val < l2.Val)
                {
                    lastNode.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    lastNode.Next = l2;
                    l2 = l2.Next;
                }
                lastNode = lastNode.Next;
            }

            if (l1 != null)
            {
                lastNode.Next = l1;
            }
            if (l2 != null)
            {
                lastNode.Next = l2;
            }

            return dummy.Next;
        }
    }
}

