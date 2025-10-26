using System;

namespace CalculatorApp
{
    public class Calculation : ICalculation
    {
        public double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Sıfıra bölmək mümkün deyil!");
                        return double.NaN;
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Yanlış əməliyyat daxil edildi!");
                    return double.NaN;
            }
        }
    }
}