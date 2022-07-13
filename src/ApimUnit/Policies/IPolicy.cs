using ApimUnit.Context;

namespace ApimUnit.Policies
{
    internal interface IPolicy
    {
        void Execute(IPolicyContext policyContext);
    }
}
