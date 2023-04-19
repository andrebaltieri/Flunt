namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires two values are NOT equals
    /// </summary>
    public Contract<TNotification> AreNotEqual<TValue>(TValue val, TValue comparer, string key = "",
        string value = "{0} should be equals to {1}")
        where TValue : IEquatable<TValue>
    {
        if (val.Equals(comparer))
            AddNotification(key, value);

        return this;
    }
    
    /// <summary>
    /// Requires two values are NOT equals
    /// </summary>
    public Contract<TNotification> AreNotEqual(object val, object comparer, string key = "", string value = "{0} should be equals to {1}")
    {
        if (val.Equals(comparer))
            AddNotification(key, value);

        return this;
    }
}