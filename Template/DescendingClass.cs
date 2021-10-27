using System.Collections.Generic;

namespace Template
{
    public class DescendingClass : BaseClass
    {
        public void SortDescending(List<int> list)
        {
            base.PreProcessing();

            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                stringBuilder.Append(item).Append(" ");
            }

            base.PostProcessing();
        }
    }
}
