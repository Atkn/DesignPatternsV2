using FactoryMethod.Logger.Concrete;
using FactoryMethod.Logger.Services;
using System;

namespace FactoryMethod.ConsoleUI
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Start the factory method 🧑‍🏭");
            CustomerService _services = new CustomerService(new LoggerFactory(),new NetworkLoggerFactory());
            _services.SetState();
            Console.WriteLine("Process is End");
        }
    }
}
