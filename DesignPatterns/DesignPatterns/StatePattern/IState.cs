﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public  interface IState
    {
        public void Handler(CustomerContext customerContext, decimal amount);
    }
}
