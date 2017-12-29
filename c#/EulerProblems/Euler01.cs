using System;
using Extensions;
using System.Collections;
using System.Collections.Generic;
using Services;

namespace EulerProblems
{
    class Euler01<T> : EulerProblem<T>
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
            
            int[] IntResults = CalculateValues(ValidateInput());

            Output.DisplayArray(IntResults);
            Output.PauseForUser("Press any key to continue...");
        }

        private int[] CalculateValues(T UserInput)
        {
            int inputValue = (int)Convert.ChangeType(UserInput, typeof(int));
            
            int[] IntResults = new int[]{
                CalculateIterative(inputValue),
                CalculateEfficient(inputValue - 1)};
            return IntResults;
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
            //efficient, uses arithmetic progression
            int SumOfThree = SumMultiples(maxRange, 3);
            int SumOfFive = SumMultiples(maxRange, 5);
            int SumOfFifteen = SumMultiples(maxRange, 3 * 5);
            return (SumOfThree + SumOfFive) - SumOfFifteen;
        }

        private int SumMultiples(int maxRange, int multiple)
        {
            int term_count = maxRange / multiple;
            int last_term = term_count * multiple;
            return (term_count * (multiple + last_term)) / 2;
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
