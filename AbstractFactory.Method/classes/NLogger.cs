using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.abstraction
{
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logging with NLogger");
        }
    }
}
