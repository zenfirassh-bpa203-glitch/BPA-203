using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class IncorrectPasswordException : System.Exception
    {
        public int AttemptsLeft { get; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Incorrect password. Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
