// #94 : https://leetcode.com/problems/binary-tree-inorder-traversal 

/**********************************************************************************
* Given a binary tree, return the inorder traversal of its nodes' values.
* For example:
* Given binary tree [1,null,2,3],
* 
*    1
*     \
*      2
*     /
*    3
* 
* return [1,3,2].
* Note: Recursive solution is trivial, could you do it iteratively?
*Example 1:
Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:
Input: root = []
Output: []
Example 3:
Input: root = [1]
Output: [1]
Example 4:
Input: root = [1,2]
Output: [2,1]
Example 5:
Input: root = [1,null,2]
Output: [1,2]
Constraints:
The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
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

