namespace Adapter
{
    public class CalculatorSummarization : ICalculator
    {
        public int CalculateValue(int value)
        {
            return value + value;
        }
    }
}
