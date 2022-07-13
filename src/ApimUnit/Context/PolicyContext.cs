using System.Collections.ObjectModel;

namespace ApimUnit.Context
{
    internal class PolicyContext : IPolicyContext
    {
        private readonly Dictionary<string, object> _variables = new();

        public PolicyContext()
        {
            Request = new Request();
            Variables = new ReadOnlyDictionary<string, object>(_variables);
        }

        public IRequest Request { get; }

        public IReadOnlyDictionary<string, object> Variables { get; }
        
        public void SetVariable(string name, object value)
        {
            _variables[name] = value;
        }
    }
}
