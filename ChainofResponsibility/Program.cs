using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain Of Responsability - Start\n");

            HandleString handle_1 = new HandleString();
            HandleInteger handle_2 = new HandleInteger();

            handle_1.SetHandler(handle_2);

            handle_1.HandleRequest("This is my argument");
            handle_1.HandleRequest(100);

            Console.WriteLine("\nChain Of Responsability - End");
        }
    }
}
