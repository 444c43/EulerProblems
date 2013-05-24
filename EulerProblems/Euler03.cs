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

        public override void EulerMain()
        {
            base.EulerMain();

            int[] IntResults = new int[]{
                (int) CalculateIterative(base.InputValue),0};

            OutputService.ConvertToString(IntResults);
        }

        private long CalculateIterative(long number)
        {
            long LargestPrime = 0;
            for (long i = number; i >= 2; --i)
            {
                if (number % i == 0 && IsPrime(i))
                {
                    LargestPrime = i;
                    break;
                }
            }
            return LargestPrime;
        }

        public bool IsPrime(long value)
        {
            if (value == 1) return false;
            if (value == 2) return true;

            for (int i = 2; i < value; ++i)
            {
                if (value % i == 0) return false;
            }

            return true;
        }
    }
}
