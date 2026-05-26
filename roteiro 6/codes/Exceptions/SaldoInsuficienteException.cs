using System.Runtime.Serialization;

namespace BancoExceptions.Exceptions;

[Serializable]
public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(string message)
        : base(message)
    {
    }

    public SaldoInsuficienteException(string message, Exception inner)
        : base(message, inner)
    {
    }

    protected SaldoInsuficienteException(
        SerializationInfo info,
        StreamingContext context)
        : base(info, context)
    {
    }
}