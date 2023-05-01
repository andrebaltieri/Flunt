namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a value is greater or equals than comparer
    /// </summary>
    public Contract<TNotification> IsGreaterOrEqualsThan<TValue>(
        TValue val, 
        TValue comparer, 
        string key = "",
        string value = "{0} should be greater or equals than {1}")
        where TValue : IComparable<TValue>
    {
        // < 0 - less than
        // 0 - equals
        // > 0 - greater than
        if (val.CompareTo(comparer) < 0)
            AddNotification(key, string.Format(value, val, comparer));

        return this;
    }
}