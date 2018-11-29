using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algo.Lib;
using Algo.Model;

namespace AlgoTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void BinaryNumberwithAlternatingBitsTest()
		{
			Dictionary<int, bool> dic = new Dictionary<int, bool>();
			dic.Add(1, true);
			dic.Add(-1, false);
			dic.Add(0, false);
			dic.Add(2, true);
			dic.Add(5, true);
			dic.Add(7, false);
			dic.Add(10, true);
			dic.Add(11, false);
			dic.Add(int.MaxValue, false);


			foreach(var temp in dic)
			{
				Assert.AreEqual(BinaryNumberwithAlternatingBits.HasAlternatingBits(temp.Key), temp.Value);
			}
		}

		[TestMethod]
		public void ReverseOnlyLetters()
		{
			string case1In = "ab-cd";
			string case1Ou = "dc-ba";

			string case2In = "";
			string case2Ou = "";

			string case3In = "  ";
			string case3Ou = "  ";

			string case4In = "a-bc-dEf-ghIj";
			string case4Ou = "j-Ih-gfE-dcba";

			string case5In = "abcde";
			string case5Ou = "edcba";

			string case6In = "Test1ng-Leet=code-Q!";
			string case6Ou = "Qedo1ct-eeLg=ntse-T!";

			string case7In = "!";
			string case7Ou = "!";

			string case8In = "!!!";
			string case8Ou = "!!!";

			string case9In = "7_28]";
			string case9Ou = "7_28]";

			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case1In), case1Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case2In), case2Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case3In), case3Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case4In), case4Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case5In), case5Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case6In), case6Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case7In), case7Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case8In), case8Ou);
			Assert.AreEqual(ReverseOnlyLettersCls.ReverseOnlyLetters(case9In), case9Ou);

		}

		[TestMethod]
		public void SearchBST_UT()
		{
			TreeNode root = new TreeNode(4);
			TreeNode rootl1 = new TreeNode(2);
			TreeNode rootr1 = new TreeNode(7);

			TreeNode leftl1 = new TreeNode(1);
			TreeNode leftr1 = new TreeNode(3);

			root.left = rootl1;
			root.right = rootr1;

			rootl1.left = leftl1;
			rootl1.right = leftr1;

			TreeNode value = BinaryTreeOp.SearchBST(root, 2);

			TreeNode val1 = BinaryTreeOp.SearchBSTStack(root, 2);

		}

		[TestMethod]
		public void MiddleNode_UT()
		{
			ListNode head = new ListNode(1);
			head.next = new ListNode(2);
			head.next.next = new ListNode(3);
			head.next.next.next = new ListNode(4);
			head.next.next.next.next = new ListNode(5);

			ListNode r1 = ListNodeOp.MiddleNode(head);

			head = new ListNode(1);
			ListNode r2 = ListNodeOp.MiddleNode(head);

			head = null;
			ListNode r3 = ListNodeOp.MiddleNode(head);
			head = new ListNode(1);
			head.next = new ListNode(2);
			head.next.next = new ListNode(3);
			head.next.next.next = new ListNode(4);

			ListNode r4 = ListNodeOp.MiddleNode(head);
		}
	}
}

