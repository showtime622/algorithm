using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Algo.Lib;
using Algo.Model;

namespace AlgorithmConsole
{
	public enum TranEnum
	{
		com = 0,
		IP = 1
	}

    class Program
    {
        public int count = 0;
        static void Main(string[] args)
        {
			DateTime date = Convert.ToDateTime("09:20");

			List<string> l1 = new List<string>();
			l1.Add("1");
			l1.Add("2");

			List<string> l2 = new List<string>();
			l2.Add("3");
			l2.Add("4");

			l1.AddRange(l2);

			ListNode newNode = new ListNode(1);
			newNode.next = new ListNode(1);
			newNode.next.next = new ListNode(2);

			ListNode node2 = new ListNode(1);
			node2.next = new ListNode(1);
			node2.next.next = new ListNode(2);
			node2.next.next.next = new ListNode(3);
			node2.next.next.next.next = new ListNode(3);

			ListNode node3 = new ListNode(1);
			node3.next = new ListNode(1);

			ListNode node4 = null;

			ListNode node5 = new ListNode(1);

			ListNode node6 = new ListNode(1);
			node6.next = new ListNode(2);
			node6.next.next = new ListNode(3);
			node6.next.next.next = new ListNode(3);
			node6.next.next.next.next = new ListNode(3);


			ListNodeOp.DeleteDuplicates(newNode);
			ListNodeOp.DeleteDuplicates(node2);
			ListNodeOp.DeleteDuplicates(node3);
			ListNodeOp.DeleteDuplicates(node4);
			ListNodeOp.DeleteDuplicates(node5);
			ListNodeOp.DeleteDuplicates(node6);



			//int[] arr1 = DIString.DiStringMatch("IDID");
			//int[] arr2 = DIString.DiStringMatch("III");
			//int[] arr3 = DIString.DiStringMatch("DDI");
			//int[] arr4 = DIString.DiStringMatch("DDD");
			//int[] arr5 = DIString.DiStringMatch("D");
			//int[] arr6 = DIString.DiStringMatch("I");
			//int[] arr7 = DIString.DiStringMatch("IIDD");
			//int[] arr8 = DIString.DiStringMatch("DDII");
			//int[] arr9 = DIString.DiStringMatch("DII");









		string date1 = "20181203141222";
			string date2 = "20181203141233";

			DateTime date3 = DateTime.ParseExact(date1, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
			

			List<string> list = new List<string>();
			list.Add("Tran_10.222.29.196_9.7.3.0_20181204152545");
			list.Add("Tran_10.222.29.196_9.7.3.0_20181204153545");
			list.Add("Tran_10.222.29.195_9.7.3.0_20181204152555");

			List<string> list2 = list.OrderBy(t => t.Split(new char[] {'_' })[3]).ToList();



			Dictionary<string, int> dic = new Dictionary<string, int>();

			dic.Add("component", 0);
			dic.Add("IP", 1);
			
			dic.Add("time", 3);
			dic.Add("version", 2);
			dic = dic.OrderBy(t => t.Value).ToDictionary(t => t.Key, t => t.Value);


			

			

		


			//int[] arr1 = new int[] { 1, 2, 2, 1 };
			//int[] arr2 = new int[] { 2, 2 };

			//List<int> list = new List<int>();
			//for(int i = 0; i < arr1.Length; i++)
			//{
			//	for(int j = 0; j < arr2.Length; j++)
			//	{
			//		if (arr1[i] == arr2[j] && !list.Contains(arr1[i]))
			//		{
			//			list.Add(arr1[i]);

			//		}
			//	}

			//}


			//int tempN = 5;

			//List<int> testcases = new List<int>();

			//bool result1 = BinaryNumberwithAlternatingBits.HasAlternatingBits(5);

			//FindDifference.FindTheDifference("abcd", "abcde");

			////TreeTraverse.traverseAllFiles(@"C:\Python34");
			//UniqueEmailAddress.NumUniqueEmails(new string[] {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
			//         string x1 = "test.mail+111";
			//         x1 = x1.Replace(".", "");
			//         string xx = TreeTraverse.getSpecificFile(@"C:\Python34", "crlf.py");

			//         Console.WriteLine("Hello World!");
			//         Console.WriteLine("Total file count " + TreeTraverse.count.ToString());
			//         Console.ReadKey();
		}
    }
}
