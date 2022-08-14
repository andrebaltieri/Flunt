namespace Flunt.Notifications
{
    public interface INotification
    {
        string Action { get; set; }
        string Message { get; set; }
        string Localization { get; set; }
    }
}