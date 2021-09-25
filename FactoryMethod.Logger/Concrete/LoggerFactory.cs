using FactoryMethod.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logger.Concrete
{
    public class LoggerFactory : ILoggerFactory
    {

        public ILogger CreateLoger()
        {
            return new Logger();
        }
    }
}
