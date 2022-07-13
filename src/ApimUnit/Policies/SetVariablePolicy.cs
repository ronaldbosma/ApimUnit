using ApimUnit.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApimUnit.Policies
{
    internal class SetVariablePolicy : IPolicy
    {
        public SetVariablePolicy(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }

        public string Value { get; }

        public void Execute(IPolicyContext policyContext)
        {
            var context = (PolicyContext)policyContext;
            context.SetVariable(Name, Value);
        }
    }
}
