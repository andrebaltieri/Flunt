namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    public Contract<TNotification> NotContains<TValue>(
        IEnumerable<TValue> list,
        TValue item,
        string key = "",
        string value = "List should contains {1}")
    {
        if (list.Contains(item))
            AddNotification(key, string.Format(value, item));

        return this;
    }

    public Contract<TNotification> NotContains(
        string text,
        string value,
        StringComparison comparison = StringComparison.OrdinalIgnoreCase,
        string key = "",
        string message = "Text should contains value {1}")
    {
        if (text.Contains(value, comparison))
            AddNotification(key, message);

        return this;
    }

    public Contract<TNotification> NotContains(
        string text,
        char value,
        StringComparison comparison = StringComparison.Ordinal,
        string key = "",
        string message = "Text should contains value {1}")
    {
        if (text.Contains(value, comparison))
            AddNotification(key, message);

        return this;
    }
}