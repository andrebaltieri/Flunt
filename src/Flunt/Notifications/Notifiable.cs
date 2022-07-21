namespace Flunt.Notifications;

public abstract class Notifiable
{
    #region Private Variables

    private readonly List<Notification> _notifications;

    #endregion

    #region Constructors

    protected Notifiable() => _notifications = new List<Notification>();

    #endregion

    #region Properties

    public IReadOnlyCollection<Notification> Notifications => _notifications;
    public bool IsValid => _notifications.Any() == false;

    #endregion

    #region Public Methods

    public void AddNotification(string key, string message) 
        => _notifications.Add(new Notification(key, message));

    public void AddNotification(Notification notification) 
        => _notifications.Add(notification);

    public void AddNotification(Type property, string message) 
        => _notifications.Add(new Notification(property.Name ?? string.Empty, message));

    public void AddNotifications(IEnumerable<Notification> notifications) 
        => _notifications.AddRange(notifications);

    public void AddNotifications(Notifiable item) 
        => AddNotifications(item.Notifications);

    public void AddNotifications(params Notifiable[] items)
    {
        foreach (var item in items)
            AddNotifications(item);
    }

    public void Clear() 
        => _notifications.Clear();

    #endregion
}