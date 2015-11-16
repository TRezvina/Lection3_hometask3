using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection3_Part3_Exceptions_Files.Exceptions
{
    public class TooMuchParametersException : Exception
    {
        public TooMuchParametersException() { }

        public TooMuchParametersException(string message) : base(message)
        {
        }

        public TooMuchParametersException(string message, Exception inner) : base(message, inner)
        {
            Console.WriteLine("!!!TooMuchParametersException!!!");
            Console.WriteLine("========================================================================");
        }
    }
}
