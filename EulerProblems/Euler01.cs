using System;
using Extensions;
using System.Collections;
using System.Collections.Generic;
using Services;

namespace EulerProblems
{
    class Euler01 : EulerProblem
    {
        public Euler01():base()
        {
            base.Name = "Euler # 1";
            base.Title = "Multiples of 3 and 5";
            base.ProblemDescription = new List<string>{
                "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.",
                "",
                "The sum of these multiples is 23.",
                "",
                "Find the sum of all the multiples of 3 or 5 below 1000."
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

            int[] IntResults = CalculateValues(UserInput);

            Output.DisplayArray(IntResults);
            Output.PauseForUser("Press any key to continue...");
        }

        private int[] CalculateValues(string UserInput)
        {
            InputValue = int.Parse(UserInput);

            int[] IntResults = new int[]{
                CalculateIterative(base.InputValue),
                CalculateEfficient(base.InputValue - 1)};
            return IntResults;
        }

        private string ValidateInput()
        {
            string UserInput = Input.GetUserInput();

            while (!UserInput.IsParsableInt())
            {
                UserInput = Input.GetUserInput();
                base.EulerMain();

            }
            return UserInput;
        }

        private int CalculateIterative(int value)
        {
            int SumTotal = 0;
            for (int x = 0; x < value; x++)
            {
                if (IsNumberMultiple(x, 3, 5))
                {
                    SumTotal += x;
                }
            }
            return SumTotal;
        }

        private int CalculateEfficient(int maxRange)
        {
            //efficient, does not use iterations
            int SumOfThrees = CalculateSumOfMultiples(maxRange, 3);
            int SumOfFive = CalculateSumOfMultiples(maxRange, 5);
            int SumOfFifteens = CalculateSumOfMultiples(maxRange, 3 * 5);
            return (SumOfThrees + SumOfFive) - SumOfFifteens;
        }

        private int CalculateSumOfMultiples(int maxRange, int multiple)
        {
            //calculation for EfficientSolution
            int Result;
            Result = (int)(float)((maxRange / multiple) / 2.0F * (maxRange - (maxRange % multiple) + multiple));
            return Result;
        }

        private bool IsNumberMultiple(int number, int multipleOne, int multipleTwo)
        {
            if (number % multipleOne == 0 || number % multipleTwo == 0)
            {
                return true;
            }
            return false;
        }
    }
}
