using System;
using System.Collections;
using System.Collections.Generic;
using InputLibrary;
using OutputLibrary;
using ValidationLibrary;

namespace EulerProblems
{
    public class Euler03
    {
        private int[] Results { get; set; }

        private string Title { get; set; }
        private List<string> Description { get; set; }
        private string[] EulerInstructions { get; set; }

        public Euler03()
        {
            Results = new int[] { 0, 0 };

            Title = "Largest Prime Factor";

            Description = new List<string>{
                "The prime factors of 13195 are 5, 7, 13 and 29.",
                "",
                "What is the largest prime factor of the number 600851475143 ?",
            };
        }

        public void EulerMain()
        {
            DisplayInstructions();
            string UserInput = QueryUser();
            int MaxRange = int.Parse(UserInput);

            int[] IntResults = new int[]{
                (int) CalculateIterative(MaxRange),0};

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
                "Let's solve Euler # 3!",
                Environment.NewLine, Environment.NewLine,
                "Enter number to find the largest prime factor: "};

            return ValidationService.ValidateUserInput(EulerInstructions);
        }

        public static long CalculateIterative(long end_range)
        {
            //naive solution; runs iterations, though stops once largest prime is found
            long Count = 0;
            long ProductVal = 1;
            long x = 0;
            long y = 0;
            for (x = 2; x <= end_range; ++x)
            {
                Count = 0;
                if (end_range % x == 0)
                {
                    for (y = 2; y < x; ++y)
                    {
                        if (x % y == 0)
                        {
                            Count = Count + 1;
                        }
                    }
                    if (Count == 0)
                    {
                        ProductVal = ProductVal * x;
                        if (ProductVal == end_range)
                        {
                            break;
                        }
                    }
                }
            }
            return x;
        }
    }
}
