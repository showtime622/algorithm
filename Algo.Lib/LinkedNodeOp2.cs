using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algo.Model;

namespace Algo.Lib
{
	public partial class ListNodeOp
	{
		/// <summary>
		/// Reference: https://leetcode.com/problems/remove-duplicates-from-sorted-list/
		/// Given a sorted linked list, delete all duplicates such that each element appear only once.
		/// Example 1:
		///Input: 1->1->2
		///Output: 1->2
		///Example 2:
		///Input: 1->1->2->3->3
		///Output: 1->2->3
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		public static ListNode DeleteDuplicates(ListNode head)
		{
			if (head == null || head.next == null)
				return head;

			ListNode root = head;
			ListNode index = head.next;

			while (head != null)
			{
				if (index == null)
				{
					head.next = index;
					break;
				}
				if (head.val == index.val)
				{
					index = index.next;
				}
				else
				{
					head.next = index;
					head = head.next;
					index = head.next;
				}
			}

			return root;
		}
		/// <summary>
		/// Get from discussion
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		public static ListNode DeleteDuplicateSol(ListNode head)
		{
			if (head == null) return null;
			ListNode curr = head;
			ListNode next;
			while (curr.next != null)
			{
				next = curr.next;
				if (curr.val == next.val)
				{    // Update next until curr and next not equal
					next = curr.next.next;
					curr.next = next;
				}
				else
				{    // Move current if no deletion
					curr = next;
				}
			}
			return head;
		}

		/// <summary>
		/// Remove all elements from a linked list of integers that have value val.

		///Example:
		///Input:  1->2->6->3->4->5->6, val = 6
		///Output: 1->2->3->4->5
		/// </summary>
		/// <param name="head"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public static ListNode RemoveElements(ListNode head, int val)
		{
			ListNode newHead = head;
			if (head == null)
			{
				return null;
			}

			ListNode newNode = new ListNode(-1);
			newNode.next = head;

			ListNode curr = newNode;

			ListNode next = curr.next;

			while (curr.next != null)
			{
				if (next.val == val)
				{
					curr.next = next.next;
				}
				else
				{
					curr = next;
				}
				next = next.next;
			}

			return newNode.next;

		}

	}
}
