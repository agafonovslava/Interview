// #99 : https://leetcode.com/problems/recover-binary-search-tree/ 

/**********************************************************************************
* Two elements of a binary search tree (BST) are swapped by mistake.
* Recover the tree without changing its structure.
* Note:
* A solution using O(n) space is pretty straight forward. Could you devise a constant space solution?
Example 1:
Input: root = [1,3,null,null,2]
Output: [3,1,null,null,2]
Explanation: 3 cannot be a left child of 1 because 3 > 1. Swapping 1 and 3 makes the BST valid.
Example 2:
Input: root = [3,1,4,null,null,2]
Output: [2,1,4,null,null,3]
Explanation: 2 cannot be in the right subtree of 3 because 2 < 3. Swapping 2 and 3 makes the BST valid.
Constraints:
The number of nodes in the tree is in the range [2, 1000].
-2^31 <= Node.val <= 2^31 - 1
To understand this, you need to first understand Morris Traversal or Morris Threading Traversal.
It take use of leaf nodes' right/left pointer to achieve O(1) space Traversal on a Binary Tree.
Below is a standard In order Morris Traversal, referred from http://www.cnblogs.com/AnnieKim/archive/2013/06/15/morristraversal.html 
(a Chinese Blog, while the graphs are great for illustration)
https://en.wikipedia.org/wiki/Threaded_binary_tree#The_array_of_Inorder_traversal
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
    public class Solution099
    {
        /// <summary>
        /// The space complexity is also O(1); the time complexity is also O(n), and the reverse order output process only increases the constant coefficient.
        /// </summary>
        /// <param name="root">Tree root</param>
        public static void RecoverTree(TreeNode root)
        {
            TreeNode pre = null, first = null, second = null;
            // Morris Traversal
            TreeNode temp = null;
            while (root != null)
            {
                if (root.Left != null)
                {
                    // connect threading for root
                    temp = root.Left;

                    while (temp.Right != null && temp.Right != root)
                        temp = temp.Right;
                    // the threading already exists
                    if (temp.Right != null)
                    {
                        if (pre != null && pre.Val > root.Val)
                        {
                            if (first == null)
                            {
                                first = pre;
                                second = root;
                            }
                            else
                            {
                                second = root;
                            }
                        }
                        pre = root;

                        temp.Right = null;
                        root = root.Right;
                    }
                    else
                    {
                        // construct the threading
                        temp.Right = root;
                        root = root.Left;
                    }
                }
                else
                {
                    if (pre != null && pre.Val > root.Val)
                    {
                        if (first == null)
                        {
                            first = pre;
                        }
                        second = root;
                    }
                    pre = root;
                    root = root.Right;
                }
            }
            // swap two node values;
            if (first != null && second != null)
            {
                int t = first.Val;
                first.Val = second.Val;
                second.Val = t;
            }
        }

        private static TreeNode firstElement = null;
        private static TreeNode secondElement = null;
        // The reason for this initialization is to avoid null pointer exception in the first comparison when prevElement has not been initialized
        private static TreeNode prevElement = new TreeNode(int.MinValue);

        public static void RecoverTreeSimple(TreeNode root)
        {
            // In order traversal to find the two elements
            traverse(root);

            // Swap the values of the two nodes
            int temp = firstElement.Val;
            firstElement.Val = secondElement.Val;
            secondElement.Val = temp;
        }

        /// <summary>
        /// So when we need to print the node values in order, 
        /// we insert System.out.println(root.val) in the place of "Do some business".
        //What is the business we are doing here? We need to find the first and second elements that are not in order right?
        //How do we find these two elements? For example, we have the following tree that is printed as in order traversal:
        //6, 3, 4, 5, 2
        //We compare each node with its next one and
        //we can find out that 6 is the first element to swap because 6 > 3 and 2 is the second element to swap because 2 < 5.
        //Really, what we are comparing is the current node and its previous node in the "in order traversal".
        /// </summary>
        /// <param name="root"></param>
        private static void traverse(TreeNode root)
        {
            if (root == null)
                return;

            traverse(root.Left);

            // If first element has not been found, assign it to prevElement (refer to 6 in the example above)
            if (firstElement == null && prevElement.Val >= root.Val)
            {
                firstElement = prevElement;
            }

            // If first element is found, assign the second element to the root (refer to 2 in the example above)
            if (firstElement != null && prevElement.Val >= root.Val)
            {
                secondElement = root;
            }
            prevElement = root;

            // End of "do some business"

            traverse(root.Right);
        }
    }
}

