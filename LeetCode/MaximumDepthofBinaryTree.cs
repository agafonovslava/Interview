// Source : https://leetcode.com/problems/maximum-depth-of-binary-tree/description/ 

/**********************************************************************************
*
* Given a binary tree, find its maximum depth.
* 
* The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
*
**********************************************************************************/

using Algorithms.Utils;
using System;
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

    public class Solution104
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;
        }
    }
}

