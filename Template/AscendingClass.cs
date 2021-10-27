using System.Collections.Generic;

namespace Template
{
    public class AscendingClass : BaseClass
    {
        public void SortAscending(List<int> list)
        {
            base.PreProcessing();

            list.Sort();
            foreach (var item in list)
            {
                stringBuilder.Append(item).Append(" ");
            }

            base.PostProcessing();
        }
    }
}
