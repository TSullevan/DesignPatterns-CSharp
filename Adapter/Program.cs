using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter - Start\n");
            float number = 5.12f;

            ICalculator calculator = new CalculatorMultiplication();
            ITarget adapter = new Adapter(calculator);
            int result = adapter.CalculateValue(number);
            Console.WriteLine(result);

            Console.WriteLine("\nAdapter - End");
        }
    }
}
