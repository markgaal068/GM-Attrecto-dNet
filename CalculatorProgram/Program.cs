using System;
using Calculator;

namespace CalculatorApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator.Calculator c = new Calculator.Calculator();

            Console.WriteLine("Írj be két számot a kivonáshoz:");
            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                int result = c.Subtract(a, b);
                Console.WriteLine($"Különbség: {result}");
            }
            else
            {
                Console.WriteLine("Érvénytelen bemenet.");
            }
        }
    }
}
