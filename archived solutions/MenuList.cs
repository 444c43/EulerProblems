using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
	public class MenuList
	{
		public static void DisplayHeaderText()
		{
			Console.WriteLine("Welcome! This program solves Euler Problems both as intended");
			Console.WriteLine("and with varying inputs (as applicable).");
			Console.WriteLine("");
		}
		public static void DisplayInstructionText()
		{
			UserInput.QueryUser("Choose from available options.");
		}
		public static List<string> GetEulerList()
		{
			List<string> problems = new List<string>();
			
			problems.Add("Sum of Multiples");
			problems.Add("Fibonnaci");
			problems.Add("Largest Prime");
			problems.Add("Palindrome");
			
			return problems;
		}
		public static void DisplayEulerList(List<string> MenuItems)
		{
			int y;
			for (y = 0; y <= MenuItems.Count - 1; y++)
			{
				Console.WriteLine("{0} - {1}", y + 1, MenuItems[y]);
			}
		}
	}
}