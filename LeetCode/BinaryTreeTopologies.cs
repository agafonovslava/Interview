// https://www.algoexpert.io/questions/Number%20Of%20Binary%20Tree%20Topologies
/********************************************************************************** 

Number of Binary Tree Topologies

Write a function that takes in a non-negative integer n and returns the number of possible
Binary Tree topologies that can be created with exactly n nodes.
A Binary Tree topology is defined as an Binary Tree configuration,
irrespective of node values. For instance, there exist only two Binary Tree topologies when n is equal to 2 :
a root node with a left node, and a root node with a right node.
Note that when n is equal to 0, there is one topology that can be created: the None/null node.

**********************************************************************************/

namespace Algorithms
{
    using System.Collections.Generic;

    public class BinaryTreeTopologies
    {
        //O(n^2) time | O(n) space
        public static int NumberOfBinaryTreeTopologies(int n)
        {
            List<int> cache = new List<int>();
            cache.Add(1);
            for (int m = 1; m < n + 1; m++)
            {
                int numberOfTrees = 0;
                for (int leftTreeSize = 0; leftTreeSize < m; leftTreeSize++)
                {
                    int rightTreeSize = m - 1 - leftTreeSize;
                    int numberOfLeftTrees = cache[leftTreeSize];
                    int numberOfRightTrees = cache[rightTreeSize];
                    numberOfTrees += numberOfLeftTrees * numberOfRightTrees;
                }
                cache.Add(numberOfTrees);
            }
            return cache[n];
        }
    }
}