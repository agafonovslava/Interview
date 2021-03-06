// https://www.algoexpert.io/questions/Compare%20Leaf%20Traversal

/**********************************************************************************
* Compare Leaf Traversal
* Write a function that takes in the root nodes of two Binary Trees and returns
* a boolean representing whether their leaf traversals are the same
* The Leaf traversal of Binary tree traverses only its leaf nodes from left to right.
* A leaf node is any node that has no left or right children..
* 
* 
* Tree 1
*					1
*				/		\
*			  2			3
*			/	\	      \
*		   4    5          6
*		       /  \
*		      7    8
*		      
*		      
* Tree 2
*					1
*				/		\
*			  2			3
*			/	\	      \
*		   4    7          5
*						./   \
*					    8     6

 Sample output: true*		     
**********************************************************************************/

using Algorithms.Utils;
using System.Collections.Generic;

namespace Algorithms
{
	using System;


	public class BinaryTreeCompareLeafTraversal
	{
		// This is an input class. Do not edit.
		public class BinaryTree
		{
			public int value;
			public BinaryTree left = null;
			public BinaryTree right = null;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}

		//O(n + m) time | O(max(h1, h2)), where n is number of nodes in the first tree
		//and m is the number of nodes in the second, h1 is the height of the first tree
		//using right pointers to store next leaf nodes in the leaf traversal
		public bool CompareLeafTraversalRecursive(BinaryTree tree1, BinaryTree tree2)
		{

			BinaryTree list1CurrentNode = connectLeafNodes(tree1, null, null)[0];
			BinaryTree list2CurrentNode = connectLeafNodes(tree2, null, null)[0];

			while (list1CurrentNode != null && list2CurrentNode != null)
			{
				if (list1CurrentNode.value != list2CurrentNode.value)
					return false;

				list1CurrentNode = list1CurrentNode.right;
				list2CurrentNode = list2CurrentNode.right;
			}

			return list1CurrentNode == null && list2CurrentNode == null;
		}

		BinaryTree[] connectLeafNodes(
			BinaryTree currentNode,
			BinaryTree head,
			BinaryTree previousNode)
		{
			if (currentNode == null)
			{
				return new BinaryTree[]
				{
				head, previousNode
				};
			}

			if (isLeafNode(currentNode))
			{
				if (previousNode == null)
					head = currentNode;
				else
					previousNode.right = currentNode;
				previousNode = currentNode;
			}

			BinaryTree[] nodes = connectLeafNodes(currentNode.left, head, previousNode);
			BinaryTree leftHead = nodes[0];
			BinaryTree leftPreviousNode = nodes[1];
			return connectLeafNodes(currentNode.right, leftHead, leftPreviousNode);
		}

		//O(n + m) time | O(h1 + h2) space where n is number of nodes in the first Binary Tree
		//m is the number in the second h1 is the height of Binary tree 1
		//Pre-order traversal on both trees at the same time, pause as soon as find leaf node on both trees
		//If they do not match return immediately 
		public bool CompareLeafTraversalStack(BinaryTree tree1, BinaryTree tree2)
		{
			Stack<BinaryTree> tree1TraversalStack = new Stack<BinaryTree>();
			tree1TraversalStack.Push(tree1);

			Stack<BinaryTree> tree2TraversalStack = new Stack<BinaryTree>();
			tree2TraversalStack.Push(tree2);

			while (tree1TraversalStack.Count > 0 && tree1TraversalStack.Count > 0)
			{
				BinaryTree tree1Leaf = getNextLeafNode(tree1TraversalStack);
				BinaryTree tree2Leaf = getNextLeafNode(tree2TraversalStack);

				if (tree1Leaf.value != tree2Leaf.value)
					return false;
			}

			return
				(tree1TraversalStack.Count == 0) &&
				(tree2TraversalStack.Count == 0);
		}

		public BinaryTree getNextLeafNode(Stack<BinaryTree> traversalStack)
		{
			BinaryTree currentNode = traversalStack.Pop();

			while (!isLeafNode(currentNode))
			{
				if (currentNode.right != null)
					traversalStack.Push(currentNode.right);
				if (currentNode.left != null)
					traversalStack.Push(currentNode.left);

				currentNode = traversalStack.Pop();
			}
			return currentNode;
		}

		public bool isLeafNode(BinaryTree node)
		{
			return (node.left == null) && (node.right == null);
		}
	}
}