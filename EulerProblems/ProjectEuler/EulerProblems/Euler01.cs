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
            string StringRange = Instructions();
            int IntRange = int.Parse(StringRange);

            int[] IntResults = new int[]{
                IterativeSolution(IntRange),
                EfficientSolution(IntRange)};

            OutputService.ConvertToString(IntResults);
        }

        private static string Instructions()
        {
            string[] data = new string[]{
                "Let's solve Euler # 1!",
                "\n", "\n",
                "Enter a maximum range value: "};
            
            return ValidationService.ValidateUserInput(data);
        }

        private static int IterativeSolution(int MaxRange)
        {
            int SumTotal = 0;
            for (int x = 0; x <= MaxRange; x++)
            {
                if (IsNumberMultiple(x, 3, 5))
                {
                    SumTotal += x;
                }
            }
            return SumTotal;
        }

        private static int EfficientSolution(int MaxRange)
        {
            //efficient, does not use iterations
            int sumofthrees = SumOfMultiplesCalc(MaxRange, 3);
            int sumoffives = SumOfMultiplesCalc(MaxRange, 5);
            int sumoffifteens = SumOfMultiplesCalc(MaxRange, 15);
            return (sumofthrees + sumoffives) - sumoffifteens;
        }

        private static int SumOfMultiplesCalc(int RangeEnd, int Multiple)
        {
            //calculation for EfficientSolution
            int Result;
            Result = (int)(float)((RangeEnd / Multiple) / 2.0F * (RangeEnd - (RangeEnd % Multiple) + Multiple));
            return Result;
        }

        private static bool IsNumberMultiple(int number, int multipleone, int multipletwo)
        {
            if (number % multipleone == 0 || number % multipletwo == 0)
            {
                return true;
            }
            return false;
        }
    }
}
