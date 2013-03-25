using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
	public class Palindrome
	{
		public static void EulerFour()
		{
			List<int> Palindromes = new List<int>(GeneratePalindromeList());
		}
		public static void PalindromeDisplayResult()
		{
		}
		public static void PalindromeNaive()
		{
		}
		public static void PalindromeEfficient()
		{
		}
		public static List<int> GeneratePalindromeList ()
		{
			List<int> palindrome_list = new List<int>();
			for (int y = 99; y >= 10; --y)
			{
				palindrome_list.Add(ReverseAndConcatenate(y));
			}
			return palindrome_list;
		}
		public static int ReverseAndConcatenate(int input_value)
		{
			char[] backward = input_value.ToString().ToCharArray();
			Array.Reverse(backward);
			string output = input_value + new string(backward);
			return int.Parse(output);			
		}
	}
}

