﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public partial class StringOp
	{
		/// <summary>
		/// Refernce: https://leetcode.com/problems/reverse-string-ii/
		/// 
		/// 
		/// Given a string and an integer k,
		/// you need to reverse the first k characters for every 2k characters 
		/// counting from the start of the string. 
		/// If there are less than k characters left, reverse all of them. 
		/// If there are less than 2k but greater than or equal to k characters, 
		/// then reverse the first k characters and left the other as original.
		/// Example:
		///Input: s = "abcdefg", k = 2
		///Output: "bacdfeg"
		///
		///Restrictions:
		///The string consists of lower English letters only.
		///Length of the given string and k will in the range[1, 10000]
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public string ReverseStr(string s, int k)
		{
			if(string.IsNullOrEmpty(s))
			{
				return s;
			}

			if(s.Length < k || k <= 0)
			{
				return s.Reverse().ToString();
			}

			string newString = "";

			if(s.Length >= k && s.Length < 2 * k)
			{
				int index = k;
				while(index >= 0)
				{
					newString += s[index--];
				}
				index = k;
				while(index < s.Length)
				{
					newString += s[index++];
				}

				return newString;
			}

			int blockCount = 0;
			if (s.Length % k == 0)
			{
				blockCount = s.Length / k;
			}
			else
			{
				blockCount = s.Length / k + 1;
			}
			
			if (s.Length >= 2 * k)
			{
				int i = 0;
				while (i < blockCount)
				{
					int index = i * k - 1;
					while (index >= i * k)
					{
						newString += s[index--];
					}

					index = k;
					while (index < 2 * k)
					{
						newString += s[index++];
					}

					i++;
				}

				return newString;
			}

			return "";
		}


		public static int MaxCountOfWords(string s)
		{
			if (string.IsNullOrEmpty(s.Trim()))
				return 0;

			s = s.Trim();
			int maxCount = 0;
			int count = 0;

			for(int i = 0; i < s.Length; i++)
			{
				if(s[i] == ' ')
				{
					maxCount = count > maxCount ? count : maxCount;
					count = 0;
				}
				else
				{
					count++;
				}
			}

			return maxCount;
		}

		/// <summary>
		/// reference: https://leetcode.com/problems/length-of-last-word/
		/// 
		/// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
		///If the last word does not exist, return 0.
		/// Input: "Hello World"
		///Output: 5
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int LengthOfLastWord(string s)
		{
			if (string.IsNullOrEmpty(s.Trim()))
			{
				return 0;
			}

			s = s.Trim();

			int count = 0;
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (s[i] == ' ')
				{
					break;
				}
				else
				{
					count++;
				}
			}

			return count;
		}

	
	}
}
