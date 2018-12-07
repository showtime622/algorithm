using Algo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public partial class ListNodeOp
	{
		/// <summary>
		/// Reference:https:///leetcode.com/problems/middle-of-the-linked-list/
		/// </summary>Given a non-empty, singly linked list with head node head, return a middle node of linked list.

		/// If there are two middle nodes, return the second middle node.
		/// Example 1:

		///Input: [1,2,3,4,5]
		///Output: Node 3 from this list (Serialization: [3,4,5])
		///The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
		///Note that we returned a ListNode object ans, such that:
		///ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
		///Example 2:

		///Input: [1,2,3,4,5,6]
		///Output: Node 4 from this list (Serialization: [4,5,6])
		///Since the list has two middle nodes with values 3 and 4, we return the second one.
		/// <param name="head"></param>
		/// <returns></returns>
		public static ListNode MiddleNode(ListNode head)
		{
			if (head == null)
				return head;

			int count = GetNodeCount(head);

			int countFound = count / 2;

			while(countFound > 0)
			{
				head = head.next;
				countFound--;
			}
			return head;
		}

		public static int GetNodeCount(ListNode root)
		{
			int count = 0;
			while(root != null)
			{
				root = root.next;
				count++;
			}

			return count;
		}

		public static ListNode MiddleNode_Sol(ListNode head)
		{
			ListNode temp = head;
			ListNode temp2 = head;

			int count = -1;

			while(temp != null)
			{
				temp = temp.next;

				if(count % 2 == 0)
				{
					temp2 = temp2.next;
				}

				count++;
			}

			return temp2;
		}
	}
}
