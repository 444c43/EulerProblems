using System;
using ProjectEuler.EulerProblems;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;


namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Euler01 Problem01 = new Euler01();
            //Euler02 Problem02 = new Euler02();
            
            //DispalyResults("Euler 01", Problem01);
            //DispalyResults("Euler 02", Problem02);

            string data = InputService.UserInput("Data");
            int data2 = ValidationService.ValidateAsInteger(data);
            Console.WriteLine(data2);
        }

        static void DispalyResults(string description, EulerProblem problem)
        {
            Console.WriteLine(description);
            Console.Write("Iterative - " + problem.IterativeSolution() + " ");
            Console.WriteLine("Efficient - " + problem.EfficientSolution());
            Console.WriteLine();
        }

        static void Euler01()
        {
            //
        }

        static void Euler02()
        {
        }
    }
}
