//driver code
using System;
using System.IO;

namespace LongestCommonPrefixString{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			Console.WriteLine(s.solve(args.ToList()));
		}
	}
}
