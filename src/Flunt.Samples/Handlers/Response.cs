namespace Flunt.Samples.Handlers;

public class Response
{
    public Response()
    {
    }

    public Response(string message)
        => Message = message;

    public string Message { get; private set; } = string.Empty;
}