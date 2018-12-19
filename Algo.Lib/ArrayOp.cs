using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo.Lib
{
	public partial class ArrayOp
	{
		/// <summary>
		/// Reference:https://leetcode.com/problems/search-insert-position/
		/// 
		/// You may assume no duplicates in the array.
		/// Example 1:

		///Input: [1,3,5,6], 5
		///Output: 2
		/// 
		/// 
		/// Example 3:

		///Input: [1,3,5,6], 7
		///Output: 4
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int SearchInsert(int[] nums, int target)
		{
			for(int i = 0; i < nums.Length; i++)
			{
				if(target == nums[i])
				{
					return i;
				}
				else if(target < nums[i])
				{
					return i;
				}
			}
			if(nums.Length == 0)
			{
				return 0;
			}
			else
			{
				return nums.Length;
			}
		}
	}
}
