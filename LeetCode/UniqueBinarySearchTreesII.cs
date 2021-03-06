// #95 : https://leetcode.com/problems/unique-binary-search-trees-ii 
/**********************************************************************************
* Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1...n.
* For example,
* Given n = 3, your program should return all 5 unique BST's shown below.
*    1         3     3      2      1
*     \       /     /      / \      \
*      3     2     1      1   3      2
*     /     /       \                 \
*    2     1         2                 3
*Example 1:
Input: n = 3
Output: [[1,null,2,null,3],[1,null,3,2],[2,1,3],[3,1,null,null,2],[3,2,null,1]]
Example 2:
Input: n = 1
Output: [[1]]
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
    public class Solution095
    {
        public static IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }

            return helper(1, n);
        }

        public static IList<TreeNode> helper(int m, int n)
        {
            List<TreeNode> result = new List<TreeNode>();
            if (m > n)
            {
                result.Add(null);
                return result;
            }

            for (int i = m; i <= n; i++)
            {
                var ls = helper(m, i - 1);
                var rs = helper(i + 1, n);
                foreach (TreeNode l in ls)
                {
                    foreach (TreeNode r in rs)
                    {
                        TreeNode curr = new TreeNode(i);
                        curr.Left = l;
                        curr.Right = r;
                        result.Add(curr);
                    }
                }
            }

            return result;
        }
    }
}

