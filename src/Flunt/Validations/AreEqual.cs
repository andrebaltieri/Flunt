namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires two values are equals
    /// </summary>
    public Contract<TNotification> AreEqual<TValue>(
        TValue val, 
        TValue comparer, 
        string key = "",
        string value = "{0} should be equals to {1}")
        where TValue : IEquatable<TValue>
    {
        if (!val.Equals(comparer))
            AddNotification(key, string.Format(value, val, comparer));

        return this;
    }
    
    /// <summary>
    /// Requires two values are equals
    /// </summary>
    public Contract<TNotification> AreEqual(
        object val, 
        object comparer, 
        string key = "", 
        string value = "{0} should be equals to {1}")
    {
        if (!val.Equals(comparer))
            AddNotification(key, string.Format(value, val, comparer));

        return this;
    }
}