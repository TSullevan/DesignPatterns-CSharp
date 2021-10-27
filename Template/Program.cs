using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template - Start");

            List<int> testList = new List<int> { 1, 5, 3 };

            Console.WriteLine("\n------------Without Template-----------");
            MethodA(testList);
            MethodB(testList);

            Console.WriteLine("\n------------With Template1-------------");
            AscendingClass ascendingClass = new AscendingClass();
            DescendingClass descendingClass = new DescendingClass();
            ascendingClass.SortAscending(testList);
            descendingClass.SortDescending(testList);

            Console.WriteLine("\n------------With Template2-------------");
            MethodDelegate(testList, SortAscending);
            MethodDelegate(testList, SortDescending);

            Console.WriteLine("\nTemplate - End");
        }

        public delegate List<int> MethodDEL(List<int> list);

        public static void MethodDelegate(List<int> list, MethodDEL function)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //PreProcessing
            stringBuilder.Append("Pre Processing [");
            //Sort
            List<int> sortedList = function(list);
            foreach (var item in sortedList)
            {
                stringBuilder.Append(item).Append(" ");
            }
            //PostProcessing
            stringBuilder.Append("] Post Processing");

            Console.WriteLine(stringBuilder.ToString());
        }

        public static void MethodAB(List<int> list, bool IsAscending)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //PreProcessing
            stringBuilder.Append("Pre Processing [");
            //Sort
            List<int> sortedList;
            if (IsAscending)
            {
                sortedList = SortAscending(list);
            }
            else
            {
                sortedList = SortDescending(list);
            }
            foreach (var item in sortedList)
            {
                stringBuilder.Append(item).Append(" ");
            }
            //PostProcessing
            stringBuilder.Append("] Post Processing");

            Console.WriteLine(stringBuilder.ToString());
        }

        public static void MethodA(List<int> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //PreProcessing
            stringBuilder.Append("Pre Processing [");
            //Sort
            var sortedList = SortAscending(list);
            foreach (var item in sortedList)
            {
                stringBuilder.Append(item).Append(" ");
            }
            //PostProcessing
            stringBuilder.Append("] Post Processing");

            Console.WriteLine(stringBuilder.ToString());
        }

        public static void MethodB(List<int> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //PreProcessing
            stringBuilder.Append("Pre Processing [");
            //Sort
            var sortedList = SortDescending(list);
            foreach (var item in sortedList)
            {
                stringBuilder.Append(item).Append(" ");
            }
            //PostProcessing
            stringBuilder.Append("] Post Processing");

            Console.WriteLine(stringBuilder.ToString());
        }

        public static List<int> SortAscending(List<int> list)
        {
            list.Sort();
            return list;
        }

        public static List<int> SortDescending(List<int> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
