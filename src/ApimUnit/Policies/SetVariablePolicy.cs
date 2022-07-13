using ApimUnit.Context;
using System.Xml.Linq;

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

        public static SetVariablePolicy CreateFrom(string element) => CreateFrom(XElement.Parse(element));

        public static SetVariablePolicy CreateFrom(XElement element)
        {
            var name = element.Attribute("name")!.Value;
            var value = element.Attribute("value")!.Value;

            return new SetVariablePolicy(name, value);
        }
    }
}
