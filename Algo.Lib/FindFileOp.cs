using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Algo.Lib
{
	public partial class BinaryTreeOp
	{
		public static void DisplayAllFiles(string path)
		{
			if(path.IsNullOrEmpty())
			{
				return;
			}

			string[] files = Directory.GetFiles(path);

			for(int i = 0; i < files.Length; i++)
			{
				Console.WriteLine("File found: " + files[i]);
			}

			string[] dires = Directory.GetDirectories(path);

			for (int i = 0; i < dires.Length; i++)
			{
				DisplayAllFiles(dires[i]);
			}
		}

		public static string getSpecifcFile(string path, string pattern)
		{
			if(path.IsNullOrEmpty() || pattern.IsNullOrEmpty())
			{
				return "";
			}

			string[] files = Directory.GetFiles(path);

			for (int i = 0; i < files.Length; i++)
			{
				if(files[i].Contains(pattern))
				{
					return files[i];
				}
			}

			string[] dires = Directory.GetDirectories(path);

			for (int i = 0; i < dires.Length; i++)
			{
				string temp = getSpecifcFile(dires[i], pattern);

				if(!temp.IsNullOrEmpty())
				{
					return temp;
				}
			}

			return string.Empty;
		}


	}
}
