// Source : https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal 

/**********************************************************************************
*
* Given inorder and postorder traversal of a tree, construct the binary tree.
* 
* Note:
* You may assume that duplicates do not exist in the tree.
* 
*
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

    public class Solution106
    {
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder == null || postorder == null || inorder.Length == 0 || postorder.Length == 0)
            {
                return null;
            }
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                map.Add(inorder[i], i);
            }
            return helper(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1, map);
        }

        private static TreeNode helper(int[] inorder, int[] postorder, int inL, int inR, int postL, int postR, Dictionary<int, int> map)
        {
            if (inL > inR || postL > postR)
                return null;
            TreeNode root = new TreeNode(postorder[postR]);
            int index = map[root.Val];
            root.Left = helper(inorder, postorder, inL, index - 1, postL, postL + index - inL - 1, map);
            root.Right = helper(inorder, postorder, index + 1, inR, postR - (inR - index), postR - 1, map);
            return root;
        }
    }
}

