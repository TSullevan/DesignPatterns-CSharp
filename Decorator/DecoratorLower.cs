using System.Text;
using System.Text.RegularExpressions;

namespace Decorator
{
    public class DecoratorLower : Decorator
    {
        Regex regex = new Regex("[a-z]");
        public DecoratorLower(IComponent component) : base(component) { }

        public override char[] Trim(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(char character in value)
            {
                if(!regex.IsMatch(character.ToString()))
                {
                    stringBuilder.Append(character);
                }
            }
            return base.Trim(stringBuilder.ToString());
        }
    }
}
