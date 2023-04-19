namespace Flunt.Notifications.Contracts;

/// <summary>
/// Contract for a notifiable object
/// </summary>
/// <typeparam name="TNotification">Notification (INotification)</typeparam>
public interface INotifiable<TNotification> where TNotification : INotification
{
    /// <summary>
    /// List of notifications
    /// </summary>
    IReadOnlyCollection<TNotification> Notifications { get; }

    /// <summary>
    /// Returns true if there are no notifications
    /// </summary>
    bool IsValid { get; }

    /// <summary>
    /// Append a notification
    /// </summary>
    /// <param name="key">Key (Doesn't need to be unique)</param>
    /// <param name="value">Value (Message)</param>
    void AddNotification(string key, string value);

    /// <summary>
    /// Append a notification
    /// </summary>
    /// <param name="notification">Notification Object (INotification)</param>
    void AddNotification(TNotification notification);

    /// <summary>
    /// Append a notification
    /// </summary>
    /// <param name="property">Property</param>
    /// <param name="message">Value (Message)</param>
    void AddNotification(Type property, string message);

    /// <summary>
    /// Append many notifications
    /// </summary>
    /// <param name="notifications">List of notifications from a INotifiable object</param>
    void AddNotifications(IReadOnlyCollection<TNotification> notifications);

    /// <summary>
    /// Append many notifications
    /// </summary>
    /// <param name="notifications">List of notifications</param>
    void AddNotifications(IList<TNotification> notifications);

    /// <summary>
    /// Append many notifications
    /// </summary>
    /// <param name="notifications">List of notifications</param>
    void AddNotifications(ICollection<TNotification> notifications);

    /// <summary>
    /// Append many notifications
    /// </summary>
    /// <param name="item">Notifiable Object</param>
    void AddNotifications(INotifiable<TNotification> item);

    /// <summary>
    /// Append many notifications
    /// </summary>
    /// <param name="items">Notifiable Objects</param>
    void AddNotifications(params INotifiable<TNotification>[] items);

    /// <summary>
    /// Append notifications from a contract
    /// </summary>
    /// <param name="contract">Contract (Notifiable Object)</param>
    void AddContract(INotifiable<TNotification> contract);

    /// <summary>
    /// Clear all notifications
    /// </summary>
    void Clear();
}