using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    public class EulerStart
    {
        Euler01 Problem01;
        Euler02 Problem02;
        Euler03 Problem03;

        public EulerStart()
        {
            Problem01 = new Euler01();
            Problem02 = new Euler02();
            Problem03 = new Euler03();
        }

        public void Start()
        {
            Problem01.EulerMain();
            Problem02.EulerMain();
            Problem03.EulerMain();
        }
    }
}
