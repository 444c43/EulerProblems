using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace ProjectEuler.EulerProblems
{
    public class Euler01 : EulerProblem
    {
        public override void EulerMain()
        {
        }

        public override int IterativeSolution()
        {
            int[] inputvalues = new int[2];
            int SumTotal = 0;
            for (int x = 0; x <= inputvalues[0]; x++)
            {
                SumTotal += CheckMultiple(x, inputvalues[1], inputvalues[3]);
            }
            return SumTotal;
        }

        public override int EfficientSolution()
        {
            //efficient, does not use iterations
            int sumofthrees = SumOfMultiplesCalc(999, 3);
            int sumoffives = SumOfMultiplesCalc(999, 5);
            int sumoffifteens = SumOfMultiplesCalc(999, 15);
            return (sumofthrees + sumoffives) - sumoffifteens;
        }

        private static int SumOfMultiplesCalc(int RangeEnd, int Multiple)
        {
            //calculation for EfficientSolution
            int Result;
            Result = (int)(float)((RangeEnd / Multiple) / 2.0F * (RangeEnd - (RangeEnd % Multiple) + Multiple));
            return Result;
        }

        private static int CheckMultiple(int iteration, int multipleone, int multipletwo)
        {
            int ReturnValue = 0;
            if (iteration % multipleone == 0 || iteration % multipletwo == 0)
            {
                ReturnValue += iteration;
            }
            else if (iteration % (multipleone + multipletwo) == 0)
            {
                ReturnValue -= iteration;
            }
            return ReturnValue;
        }
    }
}
