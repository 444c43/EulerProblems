using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler01
    {
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
