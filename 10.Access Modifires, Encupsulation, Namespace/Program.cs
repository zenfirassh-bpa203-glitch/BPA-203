using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Access_Modifires__Encupsulation__Namespace2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GET get = new GET();
            get.HorsePower = 500;
            Console.WriteLine(get.HorsePower);
        }
    }
}
