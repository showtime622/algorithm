using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algo.Lib
{
	public class DIString
	{
		/// <summary>
		/// referece: https://leetcode.com/problems/di-string-match/
		/// </summary>
		/// 
		/// 
		/// 
		/// Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.

		///Return any permutation A of[0, 1, ..., N] such that for all i = 0, ..., N-1:

		///If S[i] == I, then A[i] < A[i + 1]
		/// If S[i] == D, then A[i] > A[i + 1]
		/// <param name="S"></param>
		/// <returns></returns>
		public static int[] DiStringMatch(string S)
		{
			if(S.Length == 0)
			{
				return new int[] { };
			}
			int N = S.Length;

			List<int> list = new List<int>();
			for(int i = 0; i <= N; i++)
			{
				list.Add(i);
			}

			int left = 0;
			int right = list.Count - 1;

			while(left < N)
			{
				if(S[left] == 'D')
				{
					if(list[left] < list[left + 1] )
					{
						int temp = list[left];
						list[left] = list[right];
						list[right] = temp;
						right--;
					}
				}
				else if (S[left] == 'I')
				{
					if (list[left] > list[left + 1])
					{
						right = list.Count - 1;
						int temp = list[left];
						list[left] = list[right];
						list[right] = temp;
						right--;
					}
				}
				left++;
			}

			return list.ToArray();
		}
	}
}
