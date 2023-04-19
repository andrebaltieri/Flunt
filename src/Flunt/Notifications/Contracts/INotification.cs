namespace Flunt.Notifications.Contracts;

/// <summary>
/// Contract for a notification
/// </summary>
public interface INotification
{
    /// <summary>
    /// Key (Doesn't have to be unique)
    /// </summary>
    string Key { get; }
    
    /// <summary>
    /// Value (Message)
    /// </summary>
    string Value { get; }
}