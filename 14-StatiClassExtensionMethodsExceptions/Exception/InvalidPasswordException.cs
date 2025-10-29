using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException()
            : base ("Pasword bos ve 6 simvoldan az ola bilmez") { }
        public InvalidPasswordException(string message)
            : base(message) { }


    }
}
