namespace Flunt.Validations;

public partial class Contract
{
    #region IsMinValue

    /// <summary>
    /// Requires a long has its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMinValue(long val, string key = "",string message = "{0} should be {1}")
    {
        if (val != long.MinValue)
            AddNotification(key, string.Format(message, key, long.MinValue));

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a long has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMinValue(long val, string key = "",string message = "{0} should not be {1}")
    {
        if (val == long.MinValue)
            AddNotification(key, string.Format(message, key, long.MinValue));

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a long has its max value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMaxValue(long val, string key = "",string message = "{0} should be {1}")
    {
        if (val != long.MaxValue)
            AddNotification(key, string.Format(message, key, long.MaxValue));

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a long has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMaxValue(long val, string key = "",string message = "{0} should not be {1}")
    {
        if (val == long.MaxValue)
            AddNotification(key, string.Format(message, key, long.MinValue));

        return this;
    }

    #endregion

    #region IsBetween

    /// <summary>
    /// Requires a long is between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsBetween(long val, long start, long end, string key,
        string message = "{0} should be between {1} and {2}")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a long is not between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotBetween(long val, long start, long end, string key,
        string message = "{0} should not be between {1} and {2}")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a long
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(long val, IEnumerable<long> list, string key,
        string message = "{0} should contains the value {1}")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list does not contains a long
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(long val, IEnumerable<long> list, string key,
        string message = "{0} should not contains the value {1}")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion
}