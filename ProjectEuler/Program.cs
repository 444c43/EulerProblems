using System;
using ProjectEuler.EulerProblems;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Euler01 Problem01 = new Euler01();
            Euler02 Problem02 = new Euler02();
            
            DispalyResults("Euler 01", Problem01);
            DispalyResults("Euler 02", Problem02);

        }

        static void DispalyResults(string description, EulerProblem problem)
        {
            Console.WriteLine(description);
            Console.Write("Iterative - " + problem.IterativeSolution() + " ");
            Console.WriteLine("Efficient - " + problem.EfficientSolution());
            Console.WriteLine();
        }
    }
}
