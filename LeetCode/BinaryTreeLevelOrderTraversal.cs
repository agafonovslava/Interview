// #102 : https://leetcode.com/problems/binary-tree-level-order-traversal/description/ 

/**********************************************************************************
* Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
* For example:
* Given binary tree [3,9,20,null,null,15,7],
*     3
*    / \
*   9  20
*     /  \
*    15   7
* 
* return its level order traversal as:
* [
*   [3],
*   [9,20],
*   [15,7]
* ]
Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:
Input: root = [1]
Output: [[1]]
Example 3:
Input: root = []
Output: []
Constraints:
The number of nodes in the tree is in the range [0, 2000].
-1000 <= Node.val <= 1000
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

    public class Solution102
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }
            int h = height(root);
            for (var i = 1; i <= h; i++)
            {
                var levelResult = new List<int>();
                GivenLevel(root, i, levelResult);
                if (levelResult.Count == 0)
                {
                    break;
                }
                result.Add(levelResult);
            }
            return result;
        }

        private static int height(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int lheight = height(root.Left);
                int rheight = height(root.Right);
                if (lheight > rheight) return lheight + 1;
                else return rheight + 1;
            }
        }

        private static void GivenLevel(TreeNode root, int level, IList<int> levelResult)
        {
            if (root == null)
                return;
            if (level == 1)
            {
                levelResult.Add(root.Val);
            }
            else if (level > 1)
            {
                GivenLevel(root.Left, level - 1, levelResult);
                GivenLevel(root.Right, level - 1, levelResult);
            }
        }
    }
}

