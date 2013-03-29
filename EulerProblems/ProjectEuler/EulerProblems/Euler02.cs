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
                "\n", "\n",
                "Enter a maximum range value: "};

            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        private static int CalculateIterative(int maxRange)
        {
            int SumTotal = 0;
            int[] FibSet = new int[2] { 1, 2 };
            int Temp;
            while (FibSet[1] < maxRange)
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

        private static int CalculateEfficient(int maxRange)
        {

            return 0;
        }

        private static bool IsNumberEven(int fibOne)
        {
            if (fibOne % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
