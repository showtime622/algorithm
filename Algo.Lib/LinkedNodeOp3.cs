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
		/// Reference: https://leetcode.com/problems/linked-list-cycle/submissions/
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		public bool HasCycle(ListNode head)
		{
			if (head == null)
				return false;

			ListNode temp = head;
			ListNode run = head.next;
			try
			{
				while (temp.next != null && run.next.next != null)
				{
					temp = temp.next;
					run = run.next.next;
					if (temp == run)
						return true;
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return false;
		}

		public bool HasCycleSol(ListNode head)
		{
			if (head == null) return false;
			ListNode walker = head;
			ListNode runner = head;
			while (runner.next != null && runner.next.next != null)
			{
				walker = walker.next;
				runner = runner.next.next;
				if (walker == runner) return true;
			}
			return false;
		}
	}
}
