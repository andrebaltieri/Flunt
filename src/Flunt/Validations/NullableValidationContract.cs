namespace Flunt.Validations;

public partial class Contract
{
    #region IsNull

    /// <summary>
    /// Requires a value is null
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNull(object? val, string key = "",string message = "{0} should be null")
    {
        if (val is not null)
            AddNotification(key, string.Format(message, key));

        return this;
    }

    #endregion

    #region IsNotNull

    /// <summary>
    /// Requires a value is not null
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotNull(object? val, string key = "",string message = "{0} should be null")
    {
        if (val is null)
            AddNotification(key, string.Format(message, key));

        return this;
    }

    #endregion
}