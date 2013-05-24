using System;
using System.Collections;
using System.Collections.Generic;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler01
    {
        private int[] Results { get; set; }

        private string Title { get; set; }
        private List<string> Description { get; set; }
        private string[] EulerInstructions { get; set; }

        public Euler01()
        {
            Results = new int[] { 0, 0 };

            Title = "Multiples of 3 and 5";
            
            Description = new List<string>{
                "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.",
                "The sum of these multiples is 23.",
                "Find the sum of all the multiples of 3 or 5 below 1000."
            };
        }

        public void EulerMain()
        {
            DisplayInstructions();
            string UserInput = QueryUser();
            int MaxRange = int.Parse(UserInput);

            int[] IntResults = new int[]{
                CalculateIterative(MaxRange),
                CalculateEfficient(MaxRange - 1)};

            OutputService.ConvertToString(IntResults);
        }

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

        private int CalculateIterative(int maxRange)
        {
            int SumTotal = 0;
            for (int x = 0; x < maxRange; x++)
            {
                if (IsNumberMultiple(x, 3, 5))
                {
                    SumTotal += x;
                }
            }
            return SumTotal;
        }

        private int CalculateEfficient(int maxRange)
        {
            //efficient, does not use iterations
            int SumOfThrees = CalculateSumOfMultiples(maxRange, 3);
            int SumOfFive = CalculateSumOfMultiples(maxRange, 5);
            int SumOfFifteens = CalculateSumOfMultiples(maxRange, 3 * 5);
            return (SumOfThrees + SumOfFive) - SumOfFifteens;
        }

        private int CalculateSumOfMultiples(int maxRange, int multiple)
        {
            //calculation for EfficientSolution
            int Result;
            Result = (int)(float)((maxRange / multiple) / 2.0F * (maxRange - (maxRange % multiple) + multiple));
            return Result;
        }

        private bool IsNumberMultiple(int number, int multipleOne, int multipleTwo)
        {
            if (number % multipleOne == 0 || number % multipleTwo == 0)
            {
                return true;
            }
            return false;
        }
    }
}
