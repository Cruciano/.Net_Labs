using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic.Exceptions
{
    class AuthorizeException : Exception
    {
        private const string DefaultMessage = "Authorize exception has occured.";

        public AuthorizeException() : base(DefaultMessage)
        {

        }

        public AuthorizeException(string message) : base(message)
        {

        }
    }
}
