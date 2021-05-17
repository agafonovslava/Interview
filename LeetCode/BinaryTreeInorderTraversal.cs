// Source : https://leetcode.com/problems/binary-tree-inorder-traversal 

/**********************************************************************************
*
* Given a binary tree, return the inorder traversal of its nodes' values.
* 
* 
* For example:
* Given binary tree [1,null,2,3],
* 
*    1
*     \
*      2
*     /
*    3
* 
* 
* 
* return [1,3,2].
* 
* 
* Note: Recursive solution is trivial, could you do it iteratively?
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
    public class Solution094
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var result = new List<int>();
            InorderTraversal(root, result);


            return result;
        }

        private static IList<int> InorderTraversal(TreeNode root, List<int> result)
        {
            if (root == null)
                return null;
            if (root.Left != null)
            {
                InorderTraversal(root.Left, result);
            }
            result.Add(root.Val);
            if (root.Right != null)
            {
                InorderTraversal(root.Right, result);
            }
            return result;
        }
    }
}

