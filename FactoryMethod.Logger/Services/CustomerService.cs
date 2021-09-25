using FactoryMethod.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logger.Services
{
    public class CustomerService : ICustomerService
    {
        public ILoggerFactory _logger;
        public INetworkLoggerFactory _networkLoggerFactory;

        public CustomerService(ILoggerFactory logger, INetworkLoggerFactory networkLoggerFactory)
        {
            _logger = logger;
            _networkLoggerFactory = networkLoggerFactory;
        }   
        public bool SetState()
        {
            ILogger logger = _logger.CreateLoger();
            ILogger logger2 = _networkLoggerFactory.CreateLoggerForHttpContet();
            Console.WriteLine("Set start for the {0}", typeof(CustomerService).Name);
            Console.WriteLine("Network Factory Result:");
            logger2.Log();
            Console.WriteLine("Native Factory Result:");
            logger.Log();
            return true;
        }
    }
}
