using System;
using Extensions;
using System.Collections;
using System.Collections.Generic;
using Services;

namespace EulerProblems
{
    public class Euler03 : EulerProblem
    {
        public Euler03()
            : base()
        {
            base.Name = "Euler # 3";
            base.Title = "Largest Prime Factor";
            base.ProblemDescription = new List<string>{
                "The prime factors of 13195 are 5, 7, 13 and 29.",
                "",
                "What is the largest prime factor of the number 600851475143 ?",
            };
            base.EulerInstructions = new List<string>{
                "Let's solve " + Name,
                "\n", "\n",
                "Enter a maximum range value: "};
        }

        public override void EulerMain()
        {
            base.EulerMain();

            string UserInput = ValidateInput();

            long[] IntResults = CalculateValues(UserInput);

            Output.DisplayArray(IntResults);
            Output.PauseForUser("Press any key to continue...");
        }

        private long[] CalculateValues(string UserInput)
        {
            //NEEDS FIXED, int NEEDS BE long
            InputValue = int.Parse(UserInput);

            long[] IntResults = new long[]{
                CalculateIterative(base.InputValue),
                CalculateEfficient(base.InputValue - 1)};
            return IntResults;
        }

        private string ValidateInput()
        {
            string UserInput = Input.GetUserInput();

            while (!UserInput.IsParsableLong())
            {
                UserInput = Input.GetUserInput();
                base.EulerMain();

            }
            return UserInput;
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

        private long CalculateEfficient(long number)
        {
            return 0;
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
