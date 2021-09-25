using Singleton.Service.concrete;
using System;

namespace Singleton.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = CustomerService.CreateAsSingleton();
            customer.SetStatus("State is Online");
        }
    }
}
