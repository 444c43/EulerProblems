using System;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;
using System.Collections;
using System.Collections.Generic;

namespace EulerProblems
{
    public class EulerProblem
    {
        protected string Name { get; set; }

        protected int[] Results { get; set; }

        protected int InputValue { get; set; }

        protected string Title { get; set; }
        protected List<string> Description { get; set; }
        protected string[] EulerInstructions { get; set; }

        public EulerProblem()
        {
            Results = new int[]{};
        }

        public virtual void EulerMain()
        {
            DisplayInstructions();
            string UserInput = this.QueryUser();
            InputValue = int.Parse(UserInput);
        }

        private void DisplayInstructions()
        {
            this.Description.ForEach(delegate(String item)
            {
                Console.WriteLine(item);
            });
        }

        private string QueryUser()
        {
            string[] EulerInstructions = new string[]{
                "Let's solve " + Name,
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
