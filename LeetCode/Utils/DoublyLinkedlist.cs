namespace Algorithms.Utils
{
    /// <summary>
    /// Linked List Construction 
    /// write a doubly linked List class that has a head and tail, both of which point to either a linked List Node 
    /// or Node / null. The class should support: settings the head and tail of the linked list.
    /// Inserting nodes before and after other nodes as well as at given positions (the position of the head node is 1)
    /// removing given nodes and removing nodes with given values
    /// searching for nodes with given values
    /// Note that the setHead, setTail, insertBefore, insertAfter, insertAtPosition, and remove methods all
    /// take in actual Node s as input parameters - not integers (except for insert at position), which also
    /// takes in an integers representing the position); this means that you don't need to create any new Node
    /// in the methods.
    /// </summary>
    public class LinkedListNode
    {
        public int Value;
        public LinkedListNode Prev;
        public LinkedListNode Next;

        public LinkedListNode(int value)
        {
            this.Value = value;
        }
    }

    public class DoublyLinkedList
    {
        public LinkedListNode Head;
        public LinkedListNode Tail;

        //O(1) time | O(1) space
        public void SetHead(LinkedListNode node)
        {
            if (Head == null)
            {
                this.Head = node;
                this.Tail = node;
                return;
            }
            this.InsertBefore(Head, node);
        }

        //O(1) time | O(1) space
        public void SetTail(LinkedListNode node)
        {
            if (this.Tail == null)
            {
                this.SetHead(node);
                return;
            }
            this.InsertAfter(this.Tail, node);
        }

        //O(1) time | O(1) space
        public void InsertBefore(LinkedListNode node, LinkedListNode nodeToInsert)
        {
            if (nodeToInsert == this.Head && nodeToInsert == Tail)
                return;

            this.Remove(nodeToInsert);
            nodeToInsert.Prev = node.Prev;
            nodeToInsert.Next = node;
            if (node.Prev == null)
            {
                this.Head = nodeToInsert;
            }
            else
            {
                node.Prev.Next = nodeToInsert;
            }
            node.Prev = nodeToInsert;
        }

        // O(1) time | O(1) space
        public void InsertAfter(LinkedListNode node, LinkedListNode nodeToInsert)
        {
            if (nodeToInsert == Head && nodeToInsert == this.Tail)
                return;

            this.Remove(nodeToInsert);
            nodeToInsert.Prev = node;
            nodeToInsert.Next = node.Next;

            if (node.Next == null)
            {
                this.Tail = nodeToInsert;
            }
            else
            {
                node.Next.Prev = nodeToInsert;
            }
            node.Next = nodeToInsert;
        }

        // O(p) time | O(1) space
        public void InsertAtPosition(int position, LinkedListNode nodeToInsert)
        {
            if (position == 1)
            {
                this.SetHead(nodeToInsert);
                return;
            }

            LinkedListNode node = this.Head;
            int currentPosition = 1;

            while (node != null && currentPosition++ != position)
                node = node.Next;

            if (node != null)
            {
                this.InsertBefore(node, nodeToInsert);
            }
            else
            {
                this.SetTail(nodeToInsert);
            }
        }

        //O(n) time | O(1) space
        public void RemoveDoubleLinkedListNodesWithValue(int value)
        {
            LinkedListNode node = Head;
            while (node != null)
            {
                LinkedListNode nodeToRemove = node;
                node = node.Next;
                if (nodeToRemove.Value == value)
                    this.Remove(nodeToRemove);
            }
        }

        // O(1) time | O(1) space
        public void Remove(LinkedListNode node)
        {
            if (node == this.Head)
            {
                Head = this.Head.Next;
            }

            if (node == this.Tail)
            {
                this.Tail = this.Tail.Prev;
            }
            this.RemoveDoubleLinkedListNodeBindings(node);
        }

        //O(n) time | O(1) space
        public bool ContainsDoubleLinkedListNodeWithValue(int value)
        {
            LinkedListNode node = this.Head;
            while (node != null && node.Value != value)
            {
                node = node.Next;
            }
            return node != null;
        }

        public void RemoveDoubleLinkedListNodeBindings(LinkedListNode node)
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;
            if (node.Next != null)
                node.Next.Prev = node.Prev;
            node.Prev = null;
            node.Next = null;
        }
    }
}
