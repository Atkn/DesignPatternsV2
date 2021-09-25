using AbstractFactory.Method.abstraction;
using AbstractFactory.Method.factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.Services
{
    public class ProductService
    {
        private CrosCuttirngConcernFactory _crosCuttirngConcernFactory;
        private Logging _logging;
        private Caching _caching;
        public ProductService(CrosCuttirngConcernFactory crosCuttirngConcernFactory)
        {
            _crosCuttirngConcernFactory = crosCuttirngConcernFactory;
            _logging = _crosCuttirngConcernFactory.CreateLogger();
            _caching = _crosCuttirngConcernFactory.CreateCache();
        }

        public void GetAll()
        {
            var messageLog = "log işlemi başarılı";
            var messageCache = "log işlemi başarılı";
            //_crosCuttirngConcernFactory.CreateLogger().Log(messageLog);
            //_crosCuttirngConcernFactory.CreateCache().Cache(messageCache);
            _logging.Log(messageLog);
            _caching.Cache(messageCache);
            Console.WriteLine("Başarıyla yazıldı");
        }
    }
}
