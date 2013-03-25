using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
	public class UserInput
	{
		public static string QueryUser(string querytext)
		{
			Console.WriteLine();
			Console.WriteLine(querytext);
			Console.WriteLine();
			return Console.ReadLine();
		}
	}
}

