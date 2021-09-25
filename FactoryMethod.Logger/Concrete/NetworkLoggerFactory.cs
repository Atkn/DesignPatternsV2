using FactoryMethod.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logger.Concrete
{
    public class NetworkLoggerFactory : INetworkLoggerFactory
    {
        public ILogger CreateLoggerForHttpContet()
        {
            return new Logger();
        }
    }
}
