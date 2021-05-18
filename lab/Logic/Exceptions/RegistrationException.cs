using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic.Exceptions
{
    class RegistrationException : Exception
    {
        private const string DefaultMessage = "Registration exception has occured.";

        public RegistrationException() : base(DefaultMessage)
        {

        }

        public RegistrationException(string message) : base(message)
        {

        }
    }
}
