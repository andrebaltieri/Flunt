namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a string is not empty
    /// </summary>
    public Contract<TNotification> IsNotEmpty(
        string val,
        string key = "",
        string value = "{0} should not be empty")
    {
        if (string.IsNullOrEmpty(val))
            AddNotification(key, string.Format(value));

        return this;
    }

    /// <summary>
    /// Requires a list is not empty
    /// </summary>
    public Contract<TNotification> IsNotEmpty<T>(
        IEnumerable<T> list,
        string key = "",
        string value = "List should not be empty")
    {
        if (!list.Any())
            AddNotification(key, string.Format(value));

        return this;
    }
}