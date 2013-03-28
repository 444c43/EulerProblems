using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputLibrary
{
    public class InputService
    {
        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);

            return Console.ReadLine();
        }
    }
}
