// https://www.algoexpert.io/questions/Linked%20List%20Palindrome
/***************************************************************************************
Write a function that takes in the head of a Singly Linked List and returns a boolean
representing whether the linked List nodes form a palindrome. Your function should not make use any
auxiliary data structure.

A palindrome is usually defined as a string that's written the same forward and backward.
For a linked list's nodes to form a palindrome, their values must be the same when
read from left to right and from right to left. Node that single character strings
are palindromes, which means that single node linked lists form palindromes.

Each LinkedList node has an integer value as well as a next node pointing to the next
node in the list or to None / null if it is the tail of the list.

You can assume that the input linked list will always have a least one node; 
in other words, the head will never be None / null
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    public class LinkedListPalindromeHelper
    {

        // O(n) time | O(1) space where n is the number of nodes in the Linked List
        public static bool LinkedListPalindrome(LinkedList head)
        {
            LinkedList slowNode = head;
            LinkedList fastNode = head;

            while (fastNode != null && fastNode.next != null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }

            LinkedList reversedSecondHalfNode = reverseLinkedList(slowNode);
            LinkedList firstHalfNode = head;

            while (reversedSecondHalfNode != null)
            {
                if (reversedSecondHalfNode.value != firstHalfNode.value)
                {
                    return false;
                }
                reversedSecondHalfNode = reversedSecondHalfNode.next;
                firstHalfNode = firstHalfNode.next;
            }

            return true;
        }

        public static LinkedList reverseLinkedList(LinkedList head)
        {
            LinkedList previousNode = null;
            LinkedList currentNode = head;

            while (currentNode != null)
            {
                LinkedList nextNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }
            return previousNode;

        }
    }
}

