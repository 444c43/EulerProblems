using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;


namespace EulerProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Euler01 Problem01 = new Euler01();
            Euler02 Problem02 = new Euler02();

            Problem01.EulerMain();
            ClearConsole();
            Problem02.EulerMain();
        }

        static void ClearConsole()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
