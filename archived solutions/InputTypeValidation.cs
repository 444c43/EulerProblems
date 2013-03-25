using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
	public class InputTypeValidation
	{
		public static bool TestAsInteger(string test_value)
		{
			int i;
			return int.TryParse(test_value, out i);
		}
		public static bool TestAsDecimal(string test_value)
		{
			decimal i;
			return decimal.TryParse(test_value, out i);
		}
		public static bool TestAsDouble(string test_value)
		{
			double i;
			return double.TryParse(test_value, out i);
		}
		public static bool TestAsLong(string test_value)
		{
			long i;
			return long.TryParse(test_value, out i);
		}
	}
}