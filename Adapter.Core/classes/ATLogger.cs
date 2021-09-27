using Adapter.Core.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Core.classes
{
    public class ATLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged {0}",message);
        }
    }
}
