using ApimUnit.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApimUnit.Policies
{
    internal interface IPolicy
    {
        void Execute(IPolicyContext policyContext);
    }
}
