using PrototypeDesign;
using System;

namespace PrototypeDesing.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerPro customer = new CustomerPro();
            customer.City = "İstanbul";
            customer.Name = "Atakan";
            CustomerPro customer2 = (CustomerPro)customer.Clone();
            customer2.Name = "Belinay";
            customer2.City = "İstanbul";
            Console.WriteLine(customer.City + " " + customer.Name);
            Console.WriteLine(customer2.City + " " + customer2.Name);
        }
    }
}
