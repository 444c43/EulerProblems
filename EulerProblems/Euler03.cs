using System;
using Extensions;
using System.Collections;
using System.Collections.Generic;
using Services;

namespace EulerProblems
{
    public class Euler03 : EulerProblem
    {
        public Euler03()
            : base()
        {
            base.Name = "Euler # 3";
            base.Title = "Largest Prime Factor";
            base.ProblemDescription = new List<string>{
                "The prime factors of 13195 are 5, 7, 13 and 29.",
                "",
                "What is the largest prime factor of the number 600851475143 ?",
            };
            base.EulerInstructions = new List<string>{
                "Let's solve " + Name,
                "\n", "\n",
                "Enter a maximum range value: "};
        }

        public override void EulerMain()
        {
            base.EulerMain();

            string UserInput = ValidateInput();

            int[] IntResults = CalculateValues(UserInput);

            Output.DisplayArray(IntResults);
            Output.PauseForUser("Press any key to continue...");
        }

        private int[] CalculateValues(string UserInput)
        {
            //NEEDS FIXED, int NEEDS BE long
            
            InputValue = int.Parse(UserInput);

            int[] IntResults = new int[]{
                CalculateIterative(base.InputValue),
                CalculateEfficient(base.InputValue)};
            return IntResults;
        }

        private string ValidateInput()
        {
            string UserInput = Input.GetUserInput();

            while (!UserInput.IsParsableLong())
            {
                UserInput = Input.GetUserInput();
                base.EulerMain();

            }
            return UserInput;
        }

        private int CalculateIterative(int number)
        {
            int LargestPrime = 0;
            for (int i = number; i >= 2; --i)
            {
                if (number % i == 0 && IsPrime(i))
                {
                    LargestPrime = i;
                    break;
                }
            }
            return LargestPrime;
        }

        private int CalculateEfficient(int number)
        {
            int iteration = 2;
            List<int> list = new List<int>() { 1 };

            while (!ProductOfList(list, number))
            {
                if (number % iteration == 0)
                {
                    list.Add(iteration);
                }
                iteration += 1;
            }
            return 0;
        }

        private static bool ProductOfList(List<int> list, int number)
        {
            int product = 1;
            foreach (int member in list)
            {
                product *= member;
            }
            return (product == number);
        }

        public bool IsPrime(long value)
        {
            if (value == 1) return false;
            if (value == 2) return true;

            for (int i = 2; i < value; ++i)
            {
                if (value % i == 0) return false;
            }

            return true;
        }
    }
}
