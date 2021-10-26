using System.Text;
using System.Text.RegularExpressions;

namespace Decorator
{
    public class DecoratorUpper : Decorator
    {
        Regex regex = new Regex("[A-Z]");
        public DecoratorUpper(IComponent component) : base(component) { }

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
