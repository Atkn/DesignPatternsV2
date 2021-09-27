using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Core.classes
{
    public class Log4Net
    {
        public void LogMessage(string message, object msg =null)
        {
            Console.WriteLine("Log 4 Net:{0}", message);
        }
    }
}
