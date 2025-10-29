using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Exception
{
    public class AccountLockedException : System.Exception
    {
        public AccountLockedException()
           : base("3 defeden artiq cehd etdikde ve hesab artiq bloklananda.") { }
    }
}
