using System;
using InputLibrary;

namespace ValidationLibrary
{
    public abstract class ValidationService
    {
        public static string ValidateUserInput(string[] data)
        {
            string returnvalue = InputService.GetUserInput(data);
            while (ValidationService.ValidateAsInteger(returnvalue) == false)
            {
                InputService.DisplayErrorMessage();
                returnvalue = InputService.GetUserInput(data);
            }
            return returnvalue;
        }

        private static bool ValidateAsInteger(string inputtext)
        {
            int result = 0;
            return int.TryParse(inputtext, out result);
        }

        private static bool ValidateAsLong(string inputtext)
        {
            long result = 0;
            return long.TryParse(inputtext, out result);
        }

        private static bool ValidateAsDouble(string inputtext)
        {
            double result = 0.0;
            return double.TryParse(inputtext, out result);
        }
    }
}
