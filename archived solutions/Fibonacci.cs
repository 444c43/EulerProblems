using System;

namespace Euler_Problems
{
    public static class Fibonacci
    {
		public static void EulerTwo()
		{
			int naive_result = FibonacciNaive(4000000);
			int efficient_result = 0;
			FibonacciDisplayResult(naive_result, efficient_result);
		}
		public static void FibonacciDisplayResult(int naive_result, int efficient_result)
		{
			Console.WriteLine("Fibonacci results:");
			Console.WriteLine();
			Console.WriteLine("     Naive coding solution result: {0}", naive_result);
			Console.WriteLine("     Efficient coding solution result: {0}", efficient_result);
			Console.WriteLine();
		}
        public static int FibonacciNaive(int Rge)
        {
            int FibA = 1;
            int FibB = 2;
            int Total = 0;
            do
            {
                if (FibA % 2 == 0)
                {
                    Total = Total + FibA;
                }
                if (FibB % 2 == 0)
                {
                    Total = Total + FibB;
                }
                //Console.WriteLine("First Value: {0}  Second Value: {1}  Current Sum: {2}", FibA, FibB, Total);
                FibA = FibA + FibB;
                FibB = FibA + FibB;
            }
            while (FibB < Rge);
            return Total;
        }
	}
}