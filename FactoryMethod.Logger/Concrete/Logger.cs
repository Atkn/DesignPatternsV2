using FactoryMethod.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logger.Concrete
{
    public class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Create logger with factory logger");
        }
    }
}
