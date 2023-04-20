namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    public Contract<TNotification> Contains<TValue>(IEnumerable<TValue> value, TValue item, string key = "",
        string message = "{0} should contains {1}")
    {
        if (!value.Contains(item))
            AddNotification(key, message);

        return this;
    }
    
    public Contract<TNotification> Contains(string value, string item, string key = "",
        string message = "{0} should contains {1}")
    {
        if (!value.Contains(item))
            AddNotification(key, message);

        return this;
    }
}