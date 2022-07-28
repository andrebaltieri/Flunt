namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a Guid is empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsEmpty(Guid val, string key = "",string message = "{0} should be an empty guid")
    {
        if (val != Guid.Empty)
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a Guid is not empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotEmpty(Guid val, string key = "",string message = "{0} should not be an empty guid")
    {
        if (val == Guid.Empty)
            AddNotification(key, string.Format(message, key));

        return this;
    }
}