using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputLibrary
{
    public class OutputService
    {
        public static void DisplayOutput(string message, int result)
        {
            Console.WriteLine("{0}, {1}", message, result);
        }
    }
}
