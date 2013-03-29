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
            string StringRange = SetInstructions();
            int IntRange = int.Parse(StringRange);

            int[] IntResults = new int[]{
                CalculateIterative(IntRange),
                CalculateEfficient(IntRange)};

            OutputService.ConvertToString(IntResults);
        }

        private static string SetInstructions()
        {
            string[] data = new string[]{
                "Let's solve Euler # 2!",
                "\n", "\n",
                "Enter a maximum range value: "};

            return ValidationService.ValidateUserInput(data);
        }

        private static int CalculateIterative(int MaxRange)
        {
            int SumTotal = 0;
            int[] FibSet = new int[2] { 1, 2 };
            int Temp;
            while (FibSet[1] < MaxRange)
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

        private static int CalculateEfficient(int MaxRange)
        {

            return 0;
        }

        private static bool IsNumberEven(int SequenceValue)
        {
            if (SequenceValue % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
