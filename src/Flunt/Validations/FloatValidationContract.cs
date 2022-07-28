namespace Flunt.Validations;

public partial class Contract
{
    #region IsMinValue

    /// <summary>
    /// Requires a float has its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMinValue(float val, string key = "", string message = "{0} should be {1}")
    {
        if (val != float.MinValue)
            AddNotification(key, string.Format(message, key, float.MinValue));

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a float has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMinValue(float val, string key = "", string message = "{0} should not be {1}")
    {
        if (val == float.MinValue)
            AddNotification(key, string.Format(message, key, float.MinValue));

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a float has its max value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMaxValue(float val, string key = "", string message = "{0} should be {1}")
    {
        if (val != float.MaxValue)
            AddNotification(key, string.Format(message, key, float.MaxValue));

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a float has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMaxValue(float val, string key = "", string message = "{0} should not be {1}")
    {
        if (val == float.MaxValue)
            AddNotification(key, string.Format(message, key, float.MinValue));

        return this;
    }

    #endregion

    #region IsBetween

    /// <summary>
    /// Requires a float is between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsBetween(float val, float start, float end, string key = "",
        string message = "{0} should be between {1} and {2}")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a float is not between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotBetween(float val, float start, float end, string key = "",
        string message = "{0} should not be between {1} and {2}")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a float
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(float val, IEnumerable<float> list, string key = "",
        string message = "{0} should contains the value {1}")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list does not contains a float
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(float val, IEnumerable<float> list, string key = "",
        string message = "{0} should not contains the value {1}")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion
}