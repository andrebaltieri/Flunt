namespace Flunt.Validations;

public partial class Contract
{
    #region IsMinValue

    /// <summary>
    /// Requires a short has its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMinValue(short val, string key, string message = "Short should be min value")
    {
        if (val != short.MinValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a short has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMinValue(short val, string key, string message = "Short should not be min value")
    {
        if (val == short.MinValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a short has its max value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMaxValue(short val, string key, string message = "Short should be max value")
    {
        if (val != short.MaxValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a short has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMaxValue(short val, string key, string message = "Short should not be max value")
    {
        if (val == short.MaxValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsBetween

    /// <summary>
    /// Requires a short is between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsBetween(short val, short start, short end, string key,
        string message = "Short should be between range")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a short is not between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotBetween(short val, short start, short end, string key,
        string message = "Short should not be between range")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a short
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(short val, IEnumerable<short> list, string key,
        string message = "Short should contains a specific value")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list does not contains a short
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(short val, IEnumerable<short> list, string key,
        string message = "Short should not contains a specific value")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, message);

        return this;
    }

    #endregion
}