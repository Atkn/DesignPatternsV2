using AbstractFactory.Method.abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.classes
{
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache with MemCache");
        }
    }
}
