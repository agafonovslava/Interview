// #103 : https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/ 

/**********************************************************************************
* Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).
* For example:
* Given binary tree [3,9,20,null,null,15,7],
* 
* 3
* / \
* 9  20
* /  \
* 15   7
* 
* return its zigzag level order traversal as:
* [
* [3],
* [20,9],
* [15,7]
* ]
Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]
Example 2:
Input: root = [1]
Output: [[1]]
Example 3:
Input: root = []
Output: []
Constraints:
The number of nodes in the tree is in the range [0, 2000].
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

    public class Solution103
    {
        public static List<List<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<List<int>> res = new List<List<int>>();
            zigzag(res, root, 0);
            return res;
        }

        public static void zigzag(List<List<int>> res, TreeNode tree, int level)
        {
            if (tree == null)
                return;
            if (level > res.Count - 1)
                res.Add(new List<int>());
            if (level % 2 == 0)
                res[level].Add(tree.Val);
            else
                res[level].Insert(0, tree.Val);

            zigzag(res, tree.Left, level + 1);
            zigzag(res, tree.Right, level + 1);
        }

    }
}

