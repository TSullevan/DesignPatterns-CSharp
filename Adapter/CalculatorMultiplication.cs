namespace Adapter
{
    public class CalculatorMultiplication : ICalculator
    {
        public int CalculateValue(int value)
        {
            return value * value;
        }
    }
}
