using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApimUnit.Context
{
    internal class PolicyContext : IPolicyContext
    {
        private readonly Dictionary<string, object> _variables = new();

        public PolicyContext()
        {
            Variables = new ReadOnlyDictionary<string, object>(_variables);
        }

        public IReadOnlyDictionary<string, object> Variables { get; }
        
        public void SetVariable(string name, string value)
        {
            _variables[name] = value;
        }
    }
}
