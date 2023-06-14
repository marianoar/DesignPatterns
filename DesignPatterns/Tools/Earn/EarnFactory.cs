using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    //pdria haber echo una interface tambien
    public abstract class EarnFactory
    {
        public abstract IEarn GetEarn();
    }
}
