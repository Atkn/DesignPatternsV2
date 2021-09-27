using Adapter.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Core.services
{
    public class ProductService 
    {
        private ILogger _logger;
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }
        
        public void Save(string message)
        {
            _logger.Log(message);
            Console.WriteLine("saved");
        }
    }
}
