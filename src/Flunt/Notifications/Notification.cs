namespace Flunt.Notifications;

public sealed class Notification : INotification
{
    public Notification(string key, string message)
    {
        Key = key;
        Message = message;
    }

    public string Key { get; }
    public string Message { get; }
}