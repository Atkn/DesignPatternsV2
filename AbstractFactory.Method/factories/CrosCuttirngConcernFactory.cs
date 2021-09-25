using AbstractFactory.Method.abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.factories
{
    public abstract class CrosCuttirngConcernFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCache();
    }
}
