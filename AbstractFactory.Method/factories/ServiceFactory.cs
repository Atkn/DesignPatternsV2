using AbstractFactory.Method.abstraction;
using AbstractFactory.Method.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.factories
{
    public class ServiceFactory : CrosCuttirngConcernFactory
    {
        public override Caching CreateCache()
        {

            var caching = new MemCache();
            Console.WriteLine("caching with service factory");
            return caching;
        }

        public override Logging CreateLogger()
        {
            var logging = new NLogger();
            Console.WriteLine("logging with service factory");
            return logging;
        }
    }
}
