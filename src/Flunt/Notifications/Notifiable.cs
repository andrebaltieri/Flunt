using Flunt.Notifications.Contracts;

namespace Flunt.Notifications;

/// <summary>
/// Create a notifiable object
/// </summary>
/// <typeparam name="TNotification">Notification Type</typeparam>
public abstract class Notifiable<TNotification> : INotifiable<TNotification>
    where TNotification : INotification
{
    #region Private Members

    /// <summary>
    /// Internal list of notifications
    /// </summary>
    private readonly List<TNotification> _notifications = new();

    #endregion

    #region Public Properties

    public IReadOnlyCollection<TNotification> Notifications => _notifications;

    #endregion

    #region Constructors

    protected Notifiable()
    {
    }

    #endregion

    #region Factory Methods

    /// <summary>
    /// Try to create an instance of TNotification
    /// </summary>
    /// <param name="key">Key</param>
    /// <param name="message">Message</param>
    /// <returns></returns>
    private TNotification? GetNotificationInstance(string key, string message)
        => (TNotification)Activator.CreateInstance(typeof(TNotification), new object[] { key, message })!;

    #endregion

    #region Single Notification Methods

    /// <summary>
    /// Append a notification to the list
    /// </summary>
    /// <param name="key">Key</param>
    /// <param name="message">Message</param>
    public void AddNotification(string key, string message)
    {
        var notification = GetNotificationInstance(key, message);
        if (notification is not null)
            _notifications.Add(notification);
    }

    /// <summary>
    /// Append a notification to the list
    /// </summary>
    /// <param name="notification">Notification Object</param>
    public void AddNotification(TNotification notification)
        => _notifications.Add(notification);

    /// <summary>
    /// Append a notification to the list
    /// </summary>
    /// <param name="property">Property</param>
    /// <param name="value">Value or message</param>
    public void AddNotification(Type property, string value)
    {
        var notification = GetNotificationInstance(property?.Name ?? string.Empty, value);
        if (notification is not null)
            _notifications.Add(notification);
    }

    #endregion

    #region Multiple Notification Methods

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="notifications">Notifications</param>
    public void AddNotifications(IReadOnlyCollection<TNotification> notifications)
        => _notifications.AddRange(notifications);

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="notifications">Notifications</param>
    public void AddNotifications(IList<TNotification> notifications)
        => _notifications.AddRange(notifications);

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="notifications">Notifications</param>
    public void AddNotifications(ICollection<TNotification> notifications)
        => _notifications.AddRange(notifications);

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="item">Notifiable Object</param>
    public void AddNotifications(INotifiable<TNotification> item)
        => _notifications.AddRange(item.Notifications);

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="item">Notifiable Object</param>
    public void AddNotifications(Notifiable<TNotification> item)
        => _notifications.AddRange(item.Notifications);

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="items">Notifiable Objects</param>
    public void AddNotifications(params INotifiable<TNotification>[] items) =>
        _notifications.AddRange(items.SelectMany(x => x.Notifications));

    /// <summary>
    /// Append many notifications to the list
    /// </summary>
    /// <param name="items">Notifiable Objects</param>
    public void AddNotifications(params Notifiable<TNotification>[] items)
    {
        foreach (var item in items)
            AddNotifications(item);
    }

    #endregion

    #region Contract Methods

    /// <summary>
    /// Add notifications from a contract
    /// </summary>
    /// <param name="contract">Contract</param>
    public void AddContract(INotifiable<TNotification> contract) => AddNotifications(contract.Notifications);

    #endregion

    #region Other Methods

    /// <summary>
    /// Clear all notifications
    /// </summary>
    public void Clear() => _notifications.Clear();

    /// <summary>
    /// Returns true if there are no notifications
    /// </summary>
    public bool IsValid => _notifications.Any() == false;

    #endregion
}

/// <summary>
/// Create a notifiable object using base Notifiable and Notification classes
/// </summary>
public abstract class Notifiable : Notifiable<Notification>
{
}