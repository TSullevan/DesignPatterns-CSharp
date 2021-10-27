using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator - Start\n");

            Collection collection = new Collection();

            collection[0] = 1;
            collection[1] = 2;
            collection[1] = 3;
            collection[1] = 4;
            collection[1] = 5;
            collection[5] = 6;
            collection[1] = 7;
            collection[1] = 8;
            collection[1] = 9;
            collection[10] = 10;

            Iterator iterator = new Iterator(collection);

            Console.WriteLine("Iterating the collection...");

            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }

            Console.WriteLine("\nIterator - End");
        }
    }
}
