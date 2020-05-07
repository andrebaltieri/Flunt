namespace Flunt.Notifications
{
    public sealed class Notification
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }

        public void SetParentProperty(string parentProperty)
        {
            Property = $"{parentProperty}.{Property}";
        }
    }
}