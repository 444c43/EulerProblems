using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Euler_Problems
{
    public class SumOfMultiples
    {
        public static void EulerOne()
        {
			 int range = 999;
            int multipleone = 3;
            int multipletwo = 5;
			int naive_result = SumOfMultiplesNaive(range, multipleone, multipletwo);
            int efficient_result = SumOfMultiplesEfficient(range, multipleone, multipletwo);
			SumOfMultiplesDisplayResult(naive_result, efficient_result);
        }
		public static void SumOfMultiplesDisplayResult(int naive_result, int efficient_result)
		{
			Console.WriteLine("Sum of Multiples results:");
			Console.WriteLine();
			Console.WriteLine("     Naive coding solution result: {0}", naive_result);
			Console.WriteLine("     Efficient coding solution result: {0}", efficient_result);
			Console.WriteLine();
		}
        public static int SumOfMultiplesNaive(int range, int multipleone, int multipletwo)
        {
            //naive solution; runs iterations
            int x;
            int total = 0;
            for (x = 1; x <= range; ++x)
                if (x % multipleone == 0 || x % multipletwo == 0)
                    total = total + x;
            return total;
        }
        public static int SumOfMultiplesEfficient(int range, int multipleone, int multipletwo)
        {
            //efficient, does not use iterations
            int sumofthrees = SumOfMultiplesCalc(range, multipleone);
            int sumoffives = SumOfMultiplesCalc(range, multipletwo);
            int sumoffifteens = SumOfMultiplesCalc(range, multipleone * multipletwo);
            return sumofthrees + sumoffives - sumoffifteens;
        }
        private static int SumOfMultiplesCalc(int RE, int M)
        {
            //calculation for EfficientSolution
            int Val;
            Val = (int)(float)((RE / M) / 2.0F * (RE - (RE % M) + M));
            return Val;
        }
	}
}

