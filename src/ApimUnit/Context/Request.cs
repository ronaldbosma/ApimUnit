using System.Collections.ObjectModel;

namespace ApimUnit.Context
{
    internal class Request : IRequest
    {
        private readonly Dictionary<string, string> _matchedParameters = new();

        public Request()
        {
            MatchedParameters = new ReadOnlyDictionary<string, string>(_matchedParameters);
        }

        public IReadOnlyDictionary<string, string> MatchedParameters { get; }

        public void SetMatchedParameter(string name, string value)
        {
            _matchedParameters[name] = value;
        }
    }
}
