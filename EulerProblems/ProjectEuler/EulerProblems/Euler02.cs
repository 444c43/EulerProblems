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
            // Used a built in solution for New Line
            // Also, maybe string builder would work.
            string[] EulerInstructions = new string[]{
                "Let's solve Euler # 2!",
                Environment.NewLine, Environment.NewLine,
                "Enter a maximum range value: "};

            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        private static int CalculateIterative(int maxRange)
        {
            // I think the use of an array here might be hiding the meaning of
            // the three variables.  Actual variables like first, second and total might be
            // better.

            int SumTotal = 0;
            int[] FibSet = new int[2] { 1, 2 };
            int Temp;
            while (LimitHasNotBeenReached(maxRange, FibSet[1]))
            {
                if (IsNumberEven(FibSet[1]))
                {
                    SumTotal += FibSet[1];
                }

                // A pretty sure there is a solution that doesn't require a temp variable.
                // Take a few minutes and see if you can think of it.
                Temp = FibSet[1];
                FibSet[1] = FibSet[0]+ FibSet[1];
                FibSet[0] = Temp;
            }
            return SumTotal;
        }

        private static bool LimitHasNotBeenReached(int maxRange, int current)
        {
            // No need to pass the array here, I changed it to just an integer.  That was this method
            // doesn't need to be aware of the existence of an array.
            return current < maxRange;
        }

        private static int CalculateEfficient(int maxRange)
        {
            // TODO: Efficient solution
            return 0;
        }

        private static bool IsNumberEven(int fibOne)
        {
            // Simplified.
            return fibOne % 2 == 0;
        }
    }
}
