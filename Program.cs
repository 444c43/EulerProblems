using System;
using System.Collections.Generic;
using Services;

namespace EulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Euler01<int> Prob01 = new Euler01<int>();
            Euler02<int> Prob02 = new Euler02<int>();
            Euler03<long> Prob03 = new Euler03<long>();

            Prob01.EulerMain();
            Prob02.EulerMain();
            Prob03.EulerMain();
        }
    }
}
