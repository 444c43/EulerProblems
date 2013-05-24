using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler02
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
                "Let's solve Euler # 2!",
                Environment.NewLine, Environment.NewLine,
                "Enter a maximum range value: "};

            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        private static int CalculateIterative(int maxRange)
        {
            int SumTotal = 0;
            int[] FibSet = new int[2] { 1, 2 };
            int Temp;
            while (LimitHasNotBeenReached(maxRange, FibSet[1]))
            {
                if (IsNumberEven(FibSet[1]))
                {
                    SumTotal += FibSet[1];
                }

                Temp = FibSet[1];
                FibSet[1] = FibSet[0]+ FibSet[1];
                FibSet[0] = Temp;
            }
            return SumTotal;
        }

        private static bool LimitHasNotBeenReached(int maxRange, int current)
        {
            return current < maxRange;
        }

        private static int CalculateEfficient(int maxRange)
        {
            return 0;
        }

        private static bool IsNumberEven(int fibOne)
        {
            return fibOne % 2 == 0;
        }
    }
}
