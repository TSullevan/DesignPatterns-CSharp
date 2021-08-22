using System;

namespace Proxy
{
    public class Proxy : IService
    {
        private IService _service;
        public Proxy(IService service)
        {
            _service = service;
        }
        public void Login(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("You are young.");
            }
            else
            {
                _service.Login(age);
            }
        }
    }
}
