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

		/// <summary>
		/// Reference: https://leetcode.com/problems/insertion-sort-list/
		/// Example 1:

		//Input: 4->2->1->3
		//Output: 1->2->3->4

		///Example 2:

		///Input: -1->5->3->4->0
		///Output: -1->0->3->4->5
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		//public ListNode InsertionSortList(ListNode head)
		//{
		//	if (head == null)
		//		return head;

		//	ListNode newHead = new ListNode(1);
		//	newHead.next = head;

		//	while(head.next != null)
		//	{
		//		ListNode curr = head.next;
		//		if (head.val > curr.val)
		//		{
		//			head.next = curr.next;
		//			curr.next = head;
		//			head = curr;
		//			head = head.next;
		//		}

		//	}


		//}

		public class MyLinkedList
		{
			ListNode nodelist;
			/** Initialize your data structure here. */
			private int Node_Count = 0;
			public MyLinkedList()
			{
				nodelist = new ListNode();
			}

			/** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
			public int Get(int index)
			{
				if(index < 0 || Node_Count == 0 || Node_Count <= index)
				{
					return -1;
				}
				int count = 0;
				ListNode newNode = nodelist;
				while(newNode != null)
				{
					if(count == index)
					{
						return newNode.val;
					}
					newNode = newNode.next;
					count++;
				}

				return -1;
			}

			/** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
			public void AddAtHead(int val)
			{
				if (Node_Count == 0)
				{
					nodelist.val = val;
				}
				else
				{
					ListNode newNode = new ListNode(val);
					newNode.next = nodelist;
					nodelist = newNode;
				}

				Node_Count++;
			}

			/** Append a node of value val to the last element of the linked list. */
			public void AddAtTail(int val)
			{
				if (Node_Count == 0)
					nodelist.val = val;
				else
				{
					while(nodelist.next != null)
					{
						nodelist = nodelist.next;
					}
					nodelist.next = new ListNode(val);
				}

				Node_Count++;
			}

			/** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
			public void AddAtIndex(int index, int val)
			{
				if (index > Node_Count)
					return;
				else if (index == Node_Count)
					AddAtTail(val);
				else if (index == 0)
					AddAtHead(val);
				else
				{
					ListNode tempNode = nodelist;
					int count = 0;
					while (tempNode != null)
					{
						count++;
						if (count == index)
						{
							ListNode temp = new ListNode(val).next = tempNode.next;
							tempNode.next = temp;
							break;
						}
						tempNode = tempNode.next;
					}
					Node_Count--;
				}
			}

			/** Delete the index-th node in the linked list, if the index is valid. */
			public void DeleteAtIndex(int index)
			{

				if (index >= Node_Count)
					return;
				else if (index == 0)
				{
					nodelist = nodelist.next;
				}
				else
				{
					ListNode tempNode = nodelist;
					int count = 0;
					while (tempNode != null)
					{
						count++;
						if (count == index)
						{
							nodelist = nodelist.next;
							break;
						}
						tempNode = tempNode.next;
					}
				}
			}
		}
	}
}
