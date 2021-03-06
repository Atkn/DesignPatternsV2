using Proxy.CoreX.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.CoreX.Physical
{
    public class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _cachedValue;
        public override int Calculate()
        {
            if(_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }
            return _cachedValue;
        }
    }
}
