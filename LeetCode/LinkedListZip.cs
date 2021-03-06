// https://www.algoexpert.io/questions/Zip%20Linked%20List
/***************************************************************************************
You are given the head of a Singly LinkedList of arbitrary length k.
Write a function that zips the linked List in place and returns head

A Linked List is zipped if its nodes are in the following order, where k is the length of LinkedList:

1st node -> Kth node -> 2nd node -> (k - 1)th node -> 3rd node -> (k - 2)th node -> ...

Each LinkedList node has an integer value as well as a next node pointing to the next node in the list
to None / null if it is the tail of the list.

You can assume that the input LinkedList will always at least one node; in other words, the head will never be None/null.

Input: LinkedList = 1 -> 2 -> 3 -> 4 -> 5 -> 6 // the head node with value 1
Output: 1 -> 6 -> 2 -> 5 -> 3 -> 4 // the head node with value 1
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    public class LinkedListZip
    {
        // O (n) time | O(1) space where n is the length of the linked list
        public static LinkedList ZipLinkedListAlgo(LinkedList linkedList)
        {
            if (linkedList.next == null || linkedList.next.next == null)
            {
                return linkedList;
            }

            LinkedList firstHalfHead = linkedList;
            LinkedList secondHalfHead = splitLinkedList(linkedList);
            LinkedList reversedSecondHalfHead = reverseLinkedList(secondHalfHead);
            return interweaveLinkedListLists(firstHalfHead, reversedSecondHalfHead);
        }

        private static LinkedList splitLinkedList(LinkedList linkedList)
        {
            LinkedList slowIterator = linkedList;
            LinkedList fastIterator = linkedList;

            while (fastIterator != null && fastIterator.next != null)
            {
                slowIterator = slowIterator.next;
                fastIterator = fastIterator.next.next;
            }

            LinkedList secondHalfHead = slowIterator.next;
            slowIterator.next = null;

            return secondHalfHead;
        }

        private static LinkedList interweaveLinkedListLists(LinkedList l1, LinkedList l2)
        {
            LinkedList l1iterator = l1;
            LinkedList l2iterator = l2;
            while (l1iterator != null & l2iterator != null)
            {
                LinkedList firstHalfIteratorNext = l1iterator.next;
                LinkedList secondHalfIteratorNext = l2iterator.next;

                l1iterator.next = l2iterator;
                l2iterator.next = firstHalfIteratorNext;

                l1iterator = firstHalfIteratorNext;
                l2iterator = secondHalfIteratorNext;
            }

            return l1;
        }

        private static LinkedList reverseLinkedList(LinkedList linkedList)
        {
            LinkedList previousNode = null;
            LinkedList currentNode = linkedList;

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
