using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Method.abstraction
{
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Log with Log4Net");
        }
    }
}
