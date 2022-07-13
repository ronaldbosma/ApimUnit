using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApimUnit.Context
{
    public interface IPolicyContext
    {
        IReadOnlyDictionary<string, object> Variables { get; }
    }
}
