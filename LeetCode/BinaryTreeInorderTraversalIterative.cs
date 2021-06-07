namespace Algorithms.Utils
{

    using System;

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;
        public BinaryTree parent;

        public BinaryTree(int value)
        {
            this.value = value;
        }

        public BinaryTree(int value, BinaryTree parent)
        {
            this.value = value;
            this.parent = parent;
        }
    }

    /// <summary>
    /// Write a function that takes in a binary tree ( where nodes have an additional pointer to their parent node)
    /// and traverses it iteratively using the in order tree traversal technique. Not recursion.
    /// As the tree is being traversed, a callback function passed in as an argument to the main function
    /// should be called on each node(i.e., callback(currentNode)).
    /// Each BinaryTree node has an integer value, a parent node, a left child node, and a right child node.
    /// Children nodes can either be BinaryTree nodes themselves or None / null.
    /// 
    /// 
    /// tree =   1
    ///        /   \     
    ///       2     3
    ///      /     / \     
    ///     4     6   7    
    ///      \
    ///        9
    ///        
    /// The input callback will have been called in the following order:
    /// callback(4)
    /// callback(9)
    /// callback(2)
    /// callback(1)
    /// callback(6)
    /// callback(3)
    /// callback(7)
    /// </summary>
    public class BinaryTreeInorderTraversalIterativeHelper
    {
        //O(n) time | O(1) space
        public static void IterativeInOrderTraversal(
            BinaryTree tree,
            Action<BinaryTree> callback)
        {
            BinaryTree previousNode = null;
            BinaryTree currentNode = tree;

            while (currentNode != null)
            {
                BinaryTree nextNode;
                if (previousNode == null || previousNode == currentNode.parent)
                {
                    if (currentNode.left != null)
                        nextNode = currentNode.left;
                    else
                    {
                        callback(currentNode);
                        nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
                    }
                }
                else if (previousNode == currentNode.left)
                {
                    callback(currentNode);
                    nextNode = currentNode.right != null ? currentNode.right : currentNode.parent;
                }
                else
                {
                    nextNode = currentNode.parent;
                }
                previousNode = currentNode;
                currentNode = nextNode;
            }
        }
    }
}