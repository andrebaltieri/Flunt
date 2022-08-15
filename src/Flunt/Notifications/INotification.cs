namespace Flunt.Notifications;

public interface INotification
{
    public string Key { get; }
    public string Message { get; }
}