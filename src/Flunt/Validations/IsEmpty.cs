namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a string is empty
    /// </summary>
    public Contract<TNotification> IsEmpty(
        string val,
        string key = "",
        string value = "{0} should be empty")
    {
        if (!string.IsNullOrEmpty(val))
            AddNotification(key, string.Format(value));

        return this;
    }

    /// <summary>
    /// Requires a list is empty
    /// </summary>
    public Contract<TNotification> IsEmpty<T>(
        IEnumerable<T> list,
        string key = "",
        string value = "List should be empty")
    {
        if (list.Any())
            AddNotification(key, string.Format(value));

        return this;
    }
}