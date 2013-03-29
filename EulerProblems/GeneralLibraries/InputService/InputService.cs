using System;

namespace InputLibrary
{
    public class InputService
    {
        public static string GetUserInput(string[] prompt)
        {
            foreach (string Element in prompt)
            {
                Console.Write(Element);
            }

            return Console.ReadLine();
        }

        public static void DisplayErrorMessage()
        {
            Console.Clear();
            Console.Write("Try again!" + "\n" + "Press any key...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
