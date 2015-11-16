using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lection3_Part3_Exceptions_Files.Exceptions
{
    //[Serializable]
    public class FileNotEsistException : Exception
    {
        public FileNotEsistException()
        {
        }

        public FileNotEsistException(string message):base(message)
        {
        }

        public FileNotEsistException(string message, Exception inner) : base(message, inner)
        {
            Console.WriteLine("!!!File Access Exception!!!");
            Console.WriteLine("========================================================================");
        }
        protected FileNotEsistException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {
    }
    }
}
