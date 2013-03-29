using System;

namespace OutputLibrary
{
    public class OutputService
    {
        public static void ConvertToString(int[] intResults)
        {
            string[] stringResults = new string[] {
                "Iterative Result: ",
                intResults[0].ToString(),
                "Efficient Result: ",
                intResults[1].ToString()};

            DisplayOutput(stringResults);
        }

        private static void DisplayOutput(string[] message)
        {
            foreach (string element in message)
            {
                Console.WriteLine(element);
            }
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
