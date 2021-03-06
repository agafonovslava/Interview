namespace Algorithms
{
    using System.Collections.Generic;

    /// <summary>
    /// Write a function that takes a binary tree, flattens it, and returns its leftmost node
    /// Sample input:
    ///          1
    ///        /   \
    ///       2     3
    ///      / \   / \
    ///     4   5 6
    ///        / \
    ///       7   8
    ///       
    /// 4 <-> 2 <-> 7 <-> 5 <-> 8 <-> 1 <-> 6 <-> 3 the left most node with value 4
    /// 
    /// https://www.algoexpert.io/questions/Flatten%20Binary%20Tree
    /// </summary>
    public class BinaryTreeFlatten
    {
        // O(n) time | O(n) space where n is the number of nodes in the Binary Tree
        public static BinaryTree FlattenBinaryTreeSlow(BinaryTree root)
        {
            List<BinaryTree> inOrderNodes = getNodesInOrder(root, new List<BinaryTree>());
            for (int i = 0; i < inOrderNodes.Count - 1; i++)
            {
                BinaryTree leftNode = inOrderNodes[i];
                BinaryTree rightNode = inOrderNodes[i + 1];
                leftNode.right = rightNode;
                rightNode.left = leftNode;
            }
            return inOrderNodes[0];
        }

        public static List<BinaryTree> getNodesInOrder(BinaryTree tree, List<BinaryTree> array)
        {
            if (tree != null)
            {
                getNodesInOrder(tree.left, array);
                array.Add(tree);
                getNodesInOrder(tree.right, array);
            }
            return array;
        }


        // O (n) time | O(d) space where n is number of nodes in the Binary Tree and d is depth or height
        public static BinaryTree FlattenBinaryTreeFast(BinaryTree root)
        {
            BinaryTree leftMost = flattenTree(root)[0];
            return leftMost;
        }

        public static BinaryTree[] flattenTree(BinaryTree node)
        {
            BinaryTree leftMost;
            BinaryTree rightMost;
            if (node.left == null)
                leftMost = node;
            else
            {
                BinaryTree[] leftAndRightMostNodes = flattenTree(node.left);
                connectNodes(leftAndRightMostNodes[1], node);
                leftMost = leftAndRightMostNodes[0];
            }

            if (node.right == null)
                rightMost = node;
            else
            {
                BinaryTree[] leftAndRightMostNodes = flattenTree(node.right);
                connectNodes(node, leftAndRightMostNodes[0]);
                rightMost = leftAndRightMostNodes[1];
            }
            return new BinaryTree[] { leftMost, rightMost };
        }

        public static void connectNodes(BinaryTree left, BinaryTree right)
        {
            left.right = right;
            right.left = left;
        }

        // This is the class of the input root. Do not edit it.
        public class BinaryTree
        {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}