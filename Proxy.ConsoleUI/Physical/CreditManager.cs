using Proxy.CoreX.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proxy.CoreX.Physical
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }
            return result;
        }
    }
}
