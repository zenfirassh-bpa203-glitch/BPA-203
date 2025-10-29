using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException()
           : base("Username bos ve 3 simvoldan az ola bilmez.") { }

        public InvalidUsernameException(string message)
            : base(message) { }
    }
}
