using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_UpcastingDowncastingExplicitImplicitFinalize_Destructor_.Models
{
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public static implicit operator Animal(Cat v)
        {
           return new Animal();
        }
    }
}
