using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    interface EulerProbs
    {
        int Answer { get; private set; }
        string Title { get; private set; }
        List<string> Description { get; private set; }
        string[] EulerInstructions { get; private set; }

        private static string QueryUser();

        private int CalculateIterative();

        private int CalculateEfficient();
    }
}
