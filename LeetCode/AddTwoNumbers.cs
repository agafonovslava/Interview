// #2 : https://leetcode.com/problems/add-two-numbers/
/********************************************************************************** 
* You are given two linked lists representing two non-negative numbers. 
* The digits are stored in reverse order and each of their nodes contain a single digit. 
* Add the two numbers and return it as a linked list.
* Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
* Output: 7 -> 0 -> 8
*               
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:
Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
Constraints:
The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    public class Solution002
    {
        public static ListNode<int> AddTwoNumbers(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> head = new ListNode<int>(0);
            ListNode<int> current = head;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var x = l1 != null ? l1.Val : 0;
                var y = l2 != null ? l2.Val : 0;
                var digit = carry + x + y;
                carry = digit / 10;
                current.Next = new ListNode<int>(digit % 10);
                current = current.Next;
                if (l1 != null)
                {
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    l2 = l2.Next;
                }
            }

            if (carry > 0)
            {
                current.Next = new ListNode<int>(carry);
            }

            return head.Next;
        }

    }
}