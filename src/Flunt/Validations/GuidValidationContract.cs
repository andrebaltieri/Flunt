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
    public Contract IsEmpty(Guid val, string key, string message = "Guid should be empty")
    {
        if (val != Guid.Empty)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a Guid is not empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotEmpty(Guid val, string key, string message = "Guid should not be empty")
    {
        if (val == Guid.Empty)
            AddNotification(key, message);

        return this;
    }
}