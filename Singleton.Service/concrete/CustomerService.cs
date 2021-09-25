using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton.Service.concrete
{
    public class CustomerService
    {
        private static CustomerService _customerService;
        public string _serviceName;
        static object _lockObject = new object();
        private CustomerService() => _serviceName = typeof(CustomerService).Name;

        public static CustomerService CreateAsSingleton() 
        {
            if (_customerService == null)
            {
                lock (_lockObject)
                {
                    Console.WriteLine("Services Is Creating... ServiCeName:{0}", typeof(CustomerService).Name);
                    Thread.Sleep(5000);
                    _customerService = new CustomerService();
                    Console.WriteLine("Service is Created {0}", typeof(CustomerService).Name);
                }  
            }
                
            return _customerService;
        }
        public void SetStatus(string message)
        {
            Console.WriteLine(message);
        }
    }
}
