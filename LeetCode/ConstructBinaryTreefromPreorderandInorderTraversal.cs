// #105 : https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/ 

/**********************************************************************************
* Given preorder and inorder traversal of a tree, construct the binary tree.
* Note:
* You may assume that duplicates do not exist in the tree.
*Example 1:
Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:
Input: preorder = [-1], inorder = [-1]
Output: [-1]
Constraints:
1 <= preorder.length <= 3000
inorder.length == preorder.length
-3000 <= preorder[i], inorder[i] <= 3000
preorder and inorder consist of unique values.
Each value of inorder also appears in preorder.
preorder is guaranteed to be the preorder traversal of the tree.
inorder is guaranteed to be the inorder traversal of the tree.
**********************************************************************************/

using Algorithms.Utils;

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

    public class Solution105
    {
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null)
                return null;

            return buildTreeHelper(inorder, preorder, 0, inorder.Length - 1, preorder.Length - 1);
        }

        public static TreeNode buildTreeHelper(
            int[] inorder,
            int[] preorder,
            int inStart,
            int inEnd,
            int postEnd)
        {
            if (inStart > inEnd || postEnd < 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(0);
            root.Val = preorder[postEnd];

            int inIndex = -1;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == root.Val)
                {
                    inIndex = i;
                    break;
                }
            }

            int leftSubTreeSize = inIndex - inStart;
            int rightSubTreeSize = inEnd - inIndex;

            TreeNode left = buildTreeHelper(inorder,
                                            preorder,
                                            inStart,
                                            inIndex - 1,
                                            postEnd - (rightSubTreeSize + 1)
                                           );

            TreeNode right = buildTreeHelper(inorder,
                                             preorder,
                                             inIndex + 1,
                                             inEnd,
                                             postEnd - 1
                                            );
            root.Left = left;
            root.Right = right;

            return root;
        }
    }
}

