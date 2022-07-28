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

    protected void AddNotification(string key, string message)
        => _notifications.Add(new Notification(key, message));

    protected void AddNotifications(IEnumerable<Notification> notifications)
        => _notifications.AddRange(notifications);

    private void AddNotifications(Notifiable item)
        => AddNotifications(item.Notifications);

    protected void Assert(Notifiable item)
        => AddNotifications(item.Notifications);

    protected void AddNotifications(params Notifiable[] items)
    {
        foreach (var item in items)
            AddNotifications(item);
    }

    public void Clear()
        => _notifications.Clear();

    #endregion
}