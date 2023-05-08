namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a value is null
    /// </summary>
    public Contract<TNotification> IsNull<TValue>(
        TValue? val, 
        string key = "",
        string value = "Value should be null")
    {
        if (val is not null)
            AddNotification(key, value);

        return this;
    }
}