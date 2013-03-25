using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.EulerProblems
{
    public abstract class EulerProblem
    {
        public virtual int IterativeSolution()
        {
            return 0;
        }

        public virtual int EfficientSolution()
        {
            return 0;
        }
    }
}
