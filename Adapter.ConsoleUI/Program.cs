using Adapter.Core.classes;
using Adapter.Core.services;
using System;

namespace Adapter.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService service = new ProductService(new ATLogger());
            service.Save("kayıt işlemi gerçekleşti service 1");
            ProductService service2 = new ProductService(new Log4NetAdapter());
            service2.Save("kayıt işlemi gerçekleşti service2");
        }
    }
}
