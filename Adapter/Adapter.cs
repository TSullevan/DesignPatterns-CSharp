namespace Adapter
{
    public class Adapter : ITarget
    {
        ICalculator _calculator;
        public Adapter(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public int CalculateValue(float value)
        {
            var castValue = (int)value;
            return _calculator.CalculateValue(castValue);
        }
    }
}
