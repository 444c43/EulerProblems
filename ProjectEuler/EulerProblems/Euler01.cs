using System;
using System.Collections;
using System.Collections.Generic;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler01 : EulerProbs
    {
        public Euler01()
        {
            int Answer=0;
            string Title = "Multiples of 3 and 5";
            
            List<string> Description = new List<string>{
                "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.",
                "The sum of these multiples is 23.",
                "Find the sum of all the multiples of 3 or 5 below 1000."
            };

            string[] EulerInstructions = new string[] {
                "Let's solve Euler # 1!",
                "\n", "\n",
                "Enter a maximum range value: "
            };
        }

        public static void EulerMain()
        {
            string UserInput = QueryUser();
            int MaxRange = int.Parse(UserInput);

            int[] IntResults = new int[]{
                CalculateIterative(MaxRange),
                CalculateEfficient(MaxRange)};

            OutputService.ConvertToString(IntResults);
        }

        private static string QueryUser()
        {
            string[] EulerInstructions = new string[]{
                "Let's solve Euler # 1!",
                "\n", "\n",
                "Enter a maximum range value: "};
            
            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        private static int CalculateIterative(int maxRange)
        {
            int SumTotal = 0;
            for (int x = 0; x <= maxRange; x++)
            {
                if (IsNumberMultiple(x, 3, 5))
                {
                    SumTotal += x;
                }
            }
            return SumTotal;
        }

        private static int CalculateEfficient(int maxRange)
        {
            //efficient, does not use iterations
            int SumOfThrees = CalculateSumOfMultiples(maxRange, 3);
            int SumOfFive = CalculateSumOfMultiples(maxRange, 5);
            int SumOfFifteens = CalculateSumOfMultiples(maxRange, 3 * 5);
            return (SumOfThrees + SumOfFive) - SumOfFifteens;
        }

        private static int CalculateSumOfMultiples(int maxRange, int multiple)
        {
            //calculation for EfficientSolution
            int Result;
            Result = (int)(float)((maxRange / multiple) / 2.0F * (maxRange - (maxRange % multiple) + multiple));
            return Result;
        }

        private static bool IsNumberMultiple(int number, int multipleOne, int multipleTwo)
        {
            if (number % multipleOne == 0 || number % multipleTwo == 0)
            {
                return true;
            }
            return false;
        }
    }
}
