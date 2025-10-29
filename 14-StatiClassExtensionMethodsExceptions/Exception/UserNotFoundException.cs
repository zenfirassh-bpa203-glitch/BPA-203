using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class UserNotFoundException : System.Exception
    {
        private static object username;

        public UserNotFoundException()
            : base("Istifadeci tapilmadi") { }
        public UserNotFoundException(string message)
            : base($"User : {username} not found.") { }
    }
    
    
}

