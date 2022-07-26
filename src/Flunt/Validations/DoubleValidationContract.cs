namespace Flunt.Validations;

public partial class Contract
{
    #region IsMinValue

    /// <summary>
    /// Requires a double has its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMinValue(double val, string key, string message = "Double should be min value")
    {
        if (val != double.MinValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a double has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMinValue(double val, string key, string message = "Double should not be min value")
    {
        if (val == double.MinValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a double has its max value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMaxValue(double val, string key, string message = "Double should be max value")
    {
        if (val != double.MaxValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a double has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMaxValue(double val, string key, string message = "Double should not be max value")
    {
        if (val == double.MaxValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsBetween

    /// <summary>
    /// Requires a double is between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsBetween(double val, double start, double end, string key,
        string message = "Double should be between range")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a double is not between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotBetween(double val, double start, double end, string key,
        string message = "Double should not be between range")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a double
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(double val, IEnumerable<double> list, string key,
        string message = "Double should contains a specific value")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list does not contains a double
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(double val, IEnumerable<double> list, string key,
        string message = "Double should not contains a specific value")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, message);

        return this;
    }

    #endregion
}