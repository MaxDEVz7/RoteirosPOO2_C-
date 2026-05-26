using System.Runtime.Serialization;

namespace BancoExceptions.Exceptions;

[Serializable]
public class LimiteDiarioException : Exception
{
    public LimiteDiarioException()
    {
    }

    public LimiteDiarioException(string message)
        : base(message)
    {
    }

    public LimiteDiarioException(string message, Exception inner)
        : base(message, inner)
    {
    }

    protected LimiteDiarioException(
        SerializationInfo info,
        StreamingContext context)
        : base(info, context)
    {
    }
}