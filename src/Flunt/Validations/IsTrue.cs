namespace Flunt.Validations;

public partial class Contract<TNotification>
{
    /// <summary>
    /// Requires a bool is false
    /// </summary>
    public Contract<TNotification> IsTrue(
        bool val, 
        string key = "",
        string value = "Value should be false")
    {
        if (val == false)
            AddNotification(key, value);

        return this;
    }
}