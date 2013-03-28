using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationService
{
    public class Validation
    {
        public static int ValidateAsInteger(string inputtext)
        {
            int result = 0;
            if (int.TryParse(inputtext, out result))
            {
                return result;
            }


        }
    }
}
