using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.EulerProblems
{
    public class Euler01 : EulerProblem
    {
        public override int IterativeSolution()
        {
            int SumTotal = 0;
            for (int x = 0; x <= 999; x++)
            {
                SumTotal += CheckMultiple(x);
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

        private static int CheckMultiple(int iteration)
        {
            int ReturnValue = 0;
            if (iteration % 3 == 0 || iteration % 5 == 0)
            {
                ReturnValue += iteration;
            }
            else if (iteration % 15 == 0)
            {
                ReturnValue -= iteration;
            }
            return ReturnValue;
        }
    }
}
