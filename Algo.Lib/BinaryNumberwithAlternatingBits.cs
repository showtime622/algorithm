using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Lib
{
	public class BinaryNumberwithAlternatingBits
	{
		/// <summary>
		/// link:
		/// Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.
		/// Example 1:
		///Input: 5
		///Output: True
		///Explanation:
		///The binary representation of 5 is: 101
		///
		/// Example 2:
		///Input: 7
		///Output: False
		///Explanation:
		///The binary representation of 7 is: 111.
		/// 
		/// 
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static bool HasAlternatingBits(int n)
		{
			if(n < 0 || n == 0)
			{
				return false;
			}

			if (n == 1)
				return true;

			string binaryStr = Convert.ToString(n, 2);

			int i = 0;
			int j = 1;

			while (i < binaryStr.Length && j < binaryStr.Length)
			{
				if(binaryStr[i] != binaryStr[j])
				{
					if (i < j)
						i += 2;
					else
						j += 2;

					continue;
				}
				else
				{
					return false;
				}
			}

			return true;
		}

	}
}
