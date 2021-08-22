namespace Proxy
{
    public class ConcreteService : IService
    {
        public void Login(int age)
        {
            System.Console.WriteLine($"You are logged in. Your age is {age}");
        }
    }
}
