namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires value is greater or equal to comparer
    /// </summary>
    public Contract<TNotification> IsGreaterOrEqualThan<TValue>(
        TValue val, 
        TValue comparer, 
        string key = "",
        string value = "{0} should be greater or equal to {1}")
        where TValue : IComparable<TValue>
    {
        if (val.CompareTo(comparer) == 0)
            AddNotification(key, string.Format(value, val, comparer));

        return this;
    }
}