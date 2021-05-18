// #107 : https://leetcode.com/problems/binary-tree-level-order-traversal-ii/

/********************************************************************************** 
* Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
* For example:
* Given binary tree [3,9,20,null,null,15,7],
*     3
*    / \
*   9  20
*     /  \
*    15   7
* return its bottom-up level order traversal as:
* [
*   [15,7],
*   [9,20],
*   [3]
* ]
Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[15,7],[9,20],[3]]
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
using System.Collections;
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution107
    {
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null) return null;
            Queue q = new Queue();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int size = q.Count;
                var lvl = new List<int>();
                while (size > 0)
                {
                    TreeNode node = (TreeNode)q.Dequeue();
                    // add it to the list peer level
                    lvl.Add(node.Val);
                    if (node.Left != null) q.Enqueue(node.Left);
                    if (node.Right != null) q.Enqueue(node.Right);
                    size--;
                }
                res.Add(lvl);
            }
            return (IList<IList<int>>)res;
        }
    }
}