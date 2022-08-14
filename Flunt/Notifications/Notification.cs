namespace Flunt.Notifications
{
    public class Notification : INotification
    {
        public Notification()
        {

        }

        public Notification(string key, string message, string localization)
        {
            Action = key;
            Message = message;
            Localization = localization;
        }

        public string Action { get; set; }
        public string Message { get; set; }
        public string Localization { get; set; }
    }
}
