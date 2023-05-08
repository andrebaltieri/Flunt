namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a value is lower than comparer
    /// </summary>
    public Contract<TNotification> IsLowerThan<TValue>(
        TValue val, 
        TValue comparer, 
        string key = "",
        string value = "{0} should be lower than {1}")
        where TValue : IComparable<TValue>
    {
        // < 0 - less than
        // 0 - equals
        // > 0 - greater than
        if (val.CompareTo(comparer) >= 0)
            AddNotification(key, string.Format(value, val, comparer));

        return this;
    }
}