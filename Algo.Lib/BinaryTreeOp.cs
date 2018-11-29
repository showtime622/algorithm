using Algo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public partial class BinaryTreeOp
	{
		/// <summary>
		/// Reference:
		/// https://leetcode.com/problems/search-in-a-binary-search-tree/
		/// </summary>
		/// Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.

		//For example,

		//Given the tree:
		//  4
		// / \
		// 2   7
		/// \
		//  1   3

		//And the value to search: 2
		//You should return this subtree:

		//  2     
		// / \   
		// 1   3
		//	In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.
		/// <param name="root"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static TreeNode SearchBST(TreeNode root, int val)
		{
			if (root == null)
				return root;

			if(root.val == val)
			{
				return root;
			}
			if (root.left != null)
			{
				
				TreeNode temp = SearchBST(root.left, val);

				if(temp != null)
				{
					return temp;
				}
			}

			if(root.right != null)
			{
				TreeNode temp = SearchBST(root.right, val);

				if (temp != null)
				{
					return temp;
				}
			}

			return null;
		}

		public static TreeNode SearchBSTStack(TreeNode root, int val)
		{
			if (root == null)
				return root;

			Stack<TreeNode> stack = new Stack<TreeNode>();
			stack.Push(root);

			while(stack.Count > 0)
			{
				root = stack.Pop();

				if(root.val == val)
				{
					return root;
				}

				if (root.left != null)
					stack.Push(root.left);

				if (root.right != null)
					stack.Push(root.right);
			}

			return root;
		}
	}
}
