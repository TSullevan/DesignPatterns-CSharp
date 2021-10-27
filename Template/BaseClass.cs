using System;
using System.Text;

namespace Template
{
    public class BaseClass
    {
        public StringBuilder stringBuilder = new StringBuilder();
        protected void PreProcessing()
        {
            stringBuilder.Append("Pre Processing [");
        }

        protected void PostProcessing()
        {
            stringBuilder.Append("] Post Processing");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
