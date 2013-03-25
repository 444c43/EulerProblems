using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.EulerProblems
{
    public class Euler02 : EulerProblem
    {
        public override int IterativeSolution()
        {
            int SumTotal = 0;
            int[] FibSet = new int[2] { 1, 2 };
            int Temp;
            while (FibSet[1] < 4000001)
            {
                if (CheckEven(FibSet[1]))
                {
                    SumTotal += FibSet[1];
                }
                Temp = FibSet[1];
                FibSet[1] = FibSet[0]+ FibSet[1];
                FibSet[0] = Temp;
            }
            return SumTotal;
        }

        public override int EfficientSolution()
        {

            return 0;
        }

        private static bool CheckEven(int SequenceValue)
        {
            if (SequenceValue % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
