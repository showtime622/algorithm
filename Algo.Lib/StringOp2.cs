using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public partial class StringOp
	{
		public static bool RepeatedSubstringPattern(string s)
		{
			if (string.IsNullOrEmpty(s))
				return false;

			int curr = 0;

			string temp = "";

			while (curr < s.Length)
			{
				temp += s[curr];
			}
		}
	}
}
