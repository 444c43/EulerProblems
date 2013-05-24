using System;

namespace OutputLibrary
{
    public class OutputService
    {
        public static void ConvertToString(int[] intResults)
        {
            string[] StringResults = new string[] {
                "Iterative Result: ",
                intResults[0].ToString(),
                "Efficient Result: ",
                intResults[1].ToString()};

            DisplayOutput(StringResults);
        }

        private static void DisplayOutput(string[] resultOutput)
        {
            foreach (string Element in resultOutput)
            {
                Console.WriteLine(Element);
            }
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
