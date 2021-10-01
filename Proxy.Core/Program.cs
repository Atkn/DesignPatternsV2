using Proxy.CoreX.Abstract;
using Proxy.CoreX.Physical;
using System;

namespace Proxy.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditBase manager = new CreditManagerProxy();
            var result =manager.Calculate();
            var result2 =manager.Calculate();
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
