namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a bool is false
    /// </summary>
    public Contract<TNotification> IsFalse(
        bool val, 
        string key = "",
        string value = "Value should be false")
    {
        if (val == true)
            AddNotification(key, value);

        return this;
    }
}