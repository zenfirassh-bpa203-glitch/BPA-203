using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculation calculator = new Calculation();

            Console.Write("Birinci ededi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emeliyyatı daxil edin (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("İkinci ededi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = calculator.Calculate(num1, num2, operation);

            Console.WriteLine($"Netice: {result}");
        }
    }
}