using ApimUnit.Context;

namespace ApimUnit.Policies
{
    internal class SetVariablePolicy : IPolicy
    {
        public SetVariablePolicy(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }

        public object Value { get; }

        public void Execute(IPolicyContext policyContext)
        {
            var context = (PolicyContext)policyContext;
            context.SetVariable(Name, Value);
        }
    }
}
