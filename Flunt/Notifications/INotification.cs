namespace Flunt.Notifications
{
    public interface INotification
    {
        string Key { get; set; }
        string Message { get; set; }
    }
}