using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
	class MainClass
	{
		static void Main (string[] args)
		{
			DisplayMenu();
			ShowEulerResults();
		}
		static void DisplayMenu()
		{
			MenuList.DisplayHeaderText();
			MenuList.DisplayEulerList(MenuList.GetEulerList());
			MenuList.DisplayInstructionText();
		}
		static void ShowEulerResults()
		{
			SumOfMultiples.EulerOne();
			Fibonacci.EulerTwo();
			Factorization.EulerThree();
		}
	}

}