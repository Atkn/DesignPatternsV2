using AbstractFactory.Method.factories;
using AbstractFactory.Method.Services;
using System;

namespace AbstractFactory.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService(new ServiceFactory());
            productService.GetAll();
            Console.WriteLine("Hello World!");
        }
    }
}
