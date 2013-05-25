using System;
using System.Collections.Generic;

namespace Services
{
    public class Output
    {
        public void DisplayList(List<string> resultOutput)
        {
            foreach (string Element in resultOutput)
            {
                Console.WriteLine(Element);
            }
        }

        public void DisplayArray(int[] array)
        {
            foreach (int Element in array)
            {
                Console.WriteLine(Element);
            }
        }

        public void DisplayArray(long[] array)
        {
            foreach (long Element in array)
            {
                Console.WriteLine(Element);
            }
        }

        public void PauseForUser(string message)
        {
            Console.Write(message);
            Console.ReadKey();
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void LineBreak()
        {
            Console.WriteLine();
        }
    }
}
