using System;

namespace Euler_Problems
{
	public class Factorization
	{
		public static void EulerThree()
		{
			long naive_result = FactorizationNaive(600851475143);
			long efficient_result = 0;
			FactorizationDisplayResult(naive_result, efficient_result);
		}
		public static void FactorizationDisplayResult(long naive_result, long efficient_result)
		{
			Console.WriteLine("Factorization results:");
			Console.WriteLine();
			Console.WriteLine("     Naive coding solution result: {0}", naive_result);
			Console.WriteLine("     Efficient coding solution result: {0}", efficient_result);
			Console.WriteLine();
		}
		public static long FactorizationNaive(long end_range)
        {
            //naive solution; runs iterations, though stops once largest prime is found
            long Count = 0;
            long ProductVal = 1;
            long x = 0;
            long y = 0;
            for (x = 2; x <= end_range; ++x)
            {
                Count = 0;
                if (end_range % x == 0)
                {
                    for (y = 2; y < x; ++y)
                    {
                        if (x % y == 0)
                        {
                            Count = Count + 1;
                        }
                    }
                    if (Count == 0)
                    {
                        ProductVal = ProductVal * x;
                        if (ProductVal == end_range)
                        {
                            break;
                        }
                    }
                }
            }
			return x;
        }
	}
}