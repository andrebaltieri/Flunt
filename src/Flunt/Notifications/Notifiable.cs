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

    #region Methods

    private void AddNotifications(Notifiable item)
        => AddNotifications(item.Notifications);

    /// <summary>
    /// Add a new notification
    /// </summary>
    /// <param name="key">Key</param>
    /// <param name="message">Message</param>
    protected void AddNotification(string key, string message)
        => _notifications.Add(new Notification(key, message));

    /// <summary>
    /// Add a list of notifications
    /// </summary>
    /// <param name="notifications">Notifications</param>
    protected void AddNotifications(IEnumerable<Notification> notifications)
        => _notifications.AddRange(notifications);

    /// <summary>
    /// Add notifications from another Notifiable item
    /// This is a syntax sugar for AddNotifications(Notifiable item)
    /// </summary>
    /// <param name="item">Notifible</param>
    protected void Assert(Notifiable item)
        => AddNotifications(item.Notifications);

    /// <summary>
    /// Append notifications from other notifiable items
    /// </summary>
    /// <param name="items">Notifiable</param>
    protected void AppendNotifications(params Notifiable[] items)
    {
        foreach (var item in items)
            AddNotifications(item);
    }

    /// <summary>
    /// Clear all notifications
    /// </summary>
    public void Clear()
        => _notifications.Clear();

    #endregion
}