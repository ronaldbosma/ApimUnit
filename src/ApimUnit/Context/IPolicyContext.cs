namespace ApimUnit.Context
{
    public interface IPolicyContext
    {
        IReadOnlyDictionary<string, object> Variables { get; }
    }
}
