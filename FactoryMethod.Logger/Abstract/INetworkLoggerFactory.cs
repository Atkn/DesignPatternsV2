﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logger.Abstract
{
    public interface INetworkLoggerFactory
    {
         ILogger CreateLoggerForHttpContet();
    }
}
