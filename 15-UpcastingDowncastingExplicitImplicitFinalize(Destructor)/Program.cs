using _15_UpcastingDowncastingExplicitImplicitFinalize_Destructor_.Models;

namespace _15_UpcastingDowncastingExplicitImplicitFinalize_Destructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            Cat cat = new Cat();
            Animal animal = cat; 
            animal.Speak();


            //Downcasting
            Animal animal = new Cat(); 
            Cat cat = (Cat)animal;     
            cat.Meow();

            //Implicit Conversion
            int a = 10;
            double b = a; 
            Console.WriteLine(b);

            //Explicit Conversion
            double d = 9.8;
            int i = (int)d; 
            Console.WriteLine(i); 




        }
    }
}
