using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Lib;

namespace AlgoTest
{
	[TestClass]
	public class UnitTest3
	{
		[TestMethod]
		public void TestMethod1_StringOp_MaxCountOfWords()
		{
			string case1 = "Hello World";
			Assert.Equals(StringOp.MaxCountOfWords(case1), 5);

			string case2 = "Hello     World";
			Assert.Equals(StringOp.MaxCountOfWords(case2), 5);

			string case3 = "   Hello      World    ";
			Assert.Equals(StringOp.MaxCountOfWords(case3), 5);

			string case4 = "   Hello      World";
			Assert.Equals(StringOp.MaxCountOfWords(case4), 5);
		}
	}
}
