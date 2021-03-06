// #98 : https://leetcode.com/problems/validate-binary-search-tree 
/**********************************************************************************
* Given a binary tree, determine if it is a valid binary search tree (BST).
* Assume a BST is defined as follows:
* The left subtree of a node contains only nodes with keys less than the node's key.
* The right subtree of a node contains only nodes with keys greater than the node's key.
* Both the left and right subtrees must also be binary search trees.
* Example 1:
*     2
*    / \
*   1   3
* Binary tree [2,1,3], return true.
* Example 2:
*     1
*    / \
*   2   3
* Binary tree [1,2,3], return false.
**********************************************************************************/

using Algorithms.Utils;
using System.Collections.Generic;

namespace Algorithms
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution098
    {
        public static bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, new Queue<TreeNode>());
        }

        private static bool IsValidBST(TreeNode node, Queue<TreeNode> queue)
        {
            if (node == null)
                return true;
            if (!IsValidBST(node.Left, queue))
                return false;
            if (queue.Count > 0 && queue.Dequeue().Val >= node.Val)
                return false;
            queue.Enqueue(node);

            if (!IsValidBST(node.Right, queue))
                return false;
            return true;
        }
    }
}

