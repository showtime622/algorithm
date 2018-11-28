using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public class ReverseOnlyLettersCls
	{
		/// <summary>
		/// link:https://leetcode.com/problems/reverse-only-letters/
		/// Given a string S, return the "reversed" string where all characters 
		/// that are not a letter stay in the same place, and all letters reverse their positions.
		///Input: "ab-cd"
		///Output: "dc-ba"
		/// Example 2:
		///Input: "a-bC-dEf-ghIj"
		///Output: "j-Ih-gfE-dCba"
		///Example 3:
		///Input: "Test1ng-Leet=code-Q!"
		///Output: "Qedo1ct-eeLg=ntse-T!"
		/// 
		/// 
		/// </summary>
		/// <param name="S"></param>
		/// <returns></returns>
		public static string ReverseOnlyLetters(string S)
		{
			if(S.Trim().IsNullOrEmpty())
			{
				return S;
			}

			string newStr = string.Empty;
			int i = 0;
			int j = S.Length - 1;

			while(i < S.Length && j >= 0)
			{
				if((S[i] >= 'a' && S[i] <= 'z') || (S[i] >= 'A' && S[i] <= 'Z'))
				{
					if ((S[j] >= 'a' && S[j] <= 'z') || (S[j] >= 'A' && S[j] <= 'Z'))
					{
						newStr += S[j--];
						i++;
					}
					else
					{
						j--;
					}
				}
				else
				{
					newStr += S[i++];
				}
			}

			while(i < S.Length)
			{
				newStr += S[i++];
			}

			return newStr;
		}

	}
}
