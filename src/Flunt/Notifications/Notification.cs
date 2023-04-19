using Flunt.Notifications.Contracts;

namespace Flunt.Notifications;

/// <summary>
/// Notification
/// </summary>
public class Notification : INotification
{
    /// <summary>
    /// Create a new notification
    /// </summary>
    /// <param name="key">Key (Doesn't need to unique)</param>
    /// <param name="value">Value (message)</param>
    public Notification(string key, string value)
    {
        if (string.IsNullOrEmpty(key))
            Key = GenerateRandomKey();

        Key = key;
        Value = value;
    }

    /// <summary>
    /// Create a new notification with a random key
    /// </summary>
    /// <param name="value">Value (message)</param>
    public Notification(string value)
    {
        Key = GenerateRandomKey();
        Value = value;
    }

    /// <summary>
    /// Key used to identity a notification
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Value or message of the notification
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Cast a string to a notification with a random key
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator Notification(string value) => new(value);

    /// <summary>
    /// Cast a notification to a string
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{Key} - {Value}";

    /// <summary>
    /// Generates a random key with 6 characters
    /// </summary>
    /// <returns>Random key with 6 characters</returns>
    private static string GenerateRandomKey() => Guid.NewGuid().ToString("N")[..6].ToUpper();
}