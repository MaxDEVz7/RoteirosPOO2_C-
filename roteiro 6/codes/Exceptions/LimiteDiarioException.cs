using System.Runtime.Serialization;

namespace BancoExceptions.Exceptions;

[Serializable]
public class LimiteSaqueDiarioException : Exception
{
    public LimiteSaqueDiarioException()
    {
    }

    public LimiteSaqueDiarioException(string message)
        : base(message)
    {
    }

    public LimiteSaqueDiarioException(string message, Exception inner)
        : base(message, inner)
    {
    }

    protected LimiteSaqueDiarioException(
        SerializationInfo info,
        StreamingContext context)
        : base(info, context)
    {
    }
}