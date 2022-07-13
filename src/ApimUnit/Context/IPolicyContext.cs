namespace ApimUnit.Context
{
    public interface IPolicyContext
    {
        IRequest Request { get; }

        IReadOnlyDictionary<string, object> Variables { get; }
    }
}
