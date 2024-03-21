using System.Runtime.Serialization;

namespace HWconsole.Exceptions;

internal class TooLowTemperature: Exception
{
    public TooLowTemperature()
    {
    }

    protected TooLowTemperature(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public TooLowTemperature(string? message) : base(message)
    {
    }

    public TooLowTemperature(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}