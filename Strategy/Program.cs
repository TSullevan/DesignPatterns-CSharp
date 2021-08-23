using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy - Start\n");

            WebApplication webApplication = new WebApplication(EBrowserType.Chrome);
            webApplication.SendAsyncRequestToServer("https://www.google.com");
            Console.ReadLine();

            Console.WriteLine("\nStrategy - End");
        }
    }
}
