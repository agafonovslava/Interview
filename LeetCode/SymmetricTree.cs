// #101 : https://leetcode.com/problems/symmetric-tree/ 
/**********************************************************************************
* Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
* For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
*     1
*    / \
*   2   2
*  / \ / \
* 3  4 4  3
* But the following [1,2,2,null,3,null,3]  is not:
* 
*     1
*    / \
*   2   2
*    \   \
*    3    3
* 
* Note:
* Bonus points if you could solve it both recursively and iteratively.
Example 1:
Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:
Input: root = [1,2,2,null,3,null,3]
Output: false
Constraints:
The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100
**********************************************************************************/

using Algorithms.Utils;

namespace Algorithms
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode Right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution101
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return helper(root.Left, root.Right);
        }
        public static bool helper(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;
            if (root1 == null || root2 == null)
                return false;
            if (root1.Val != root2.Val)
                return false;
            return helper(root1.Left, root2.Right) && helper(root1.Right, root2.Left);
        }
    }
}

