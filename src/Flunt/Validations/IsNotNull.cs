namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a value is not null
    /// </summary>
    public Contract<TNotification> IsNotNull<TValue>(
        TValue? val, 
        string key = "",
        string value = "Value should not be null")
    {
        if (val is null)
            AddNotification(key, value);

        return this;
    }
}