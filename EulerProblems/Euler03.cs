using System;
using System.Collections;
using System.Collections.Generic;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler03 : EulerProblem
    {
        public Euler03():base()
        {
            base.Name = "Euler # 3";
            base.Title = "Largest Prime Factor";
            base.Description = new List<string>{
                "The prime factors of 13195 are 5, 7, 13 and 29.",
                "",
                "What is the largest prime factor of the number 600851475143 ?",
            };
        }

        public void EulerMain()
        {
            base.EulerMain();

            int[] IntResults = new int[]{
                (int) CalculateIterative(base.InputValue),0};

            OutputService.ConvertToString(IntResults);
        }

        public static long CalculateIterative(long end_range)
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
