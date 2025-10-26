using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Access_Modifires__Encupsulation__Namespace
{
    internal class Person
    {
        public string Name;
        public string surname;
        private int age; //ancaq Person class-i ichinden daxil olmaq olar

        public Person(string name) { 
            this.Name = name;
        }

        public void GetName() {
            Console.WriteLine($"{Name}");
        }
    }


   
}
