using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;
using System.Collections;
using System.Collections.Generic;

namespace EulerProblems
{
    public abstract class EulerProblem
    {
        private int[] Results { get; set; }

        private string Title { get; set; }
        private List<string> Description { get; set; }
        private string[] EulerInstructions { get; set; }

        EulerProblem()
        {
            Results = new int[]{};
        }

        public void EulerMain() { }

        private void DisplayInstructions()
        {
            Description.ForEach(delegate(String item)
            {
                Console.WriteLine(item);
            });
        }

        private string QueryUser()
        {
            string[] EulerInstructions = new string[]{
                "Let's solve Euler # 1!",
                "\n", "\n",
                "Enter a maximum range value: "};

            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        private int CalculateIterative(int value)
        {
            return 0;
        }

        private int CalculateEfficient(int value)
        {
            return 0;
        }
    }
}
