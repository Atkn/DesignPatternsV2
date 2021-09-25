using AbstractFactory.Method.abstraction;
using AbstractFactory.Method.classes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AbstractFactory.Method.factories
{
    public class FactorySetter : CrosCuttirngConcernFactory
    {
        public override Caching CreateCache()
        {
            Console.WriteLine("Factory sett is running redis ");
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            Console.WriteLine("Factory sett is log4net");
            return new Log4NetLogger();
        }
    }
}
