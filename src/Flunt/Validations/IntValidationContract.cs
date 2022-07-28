namespace Flunt.Validations;

public partial class Contract
{
    #region IsMinValue

    /// <summary>
    /// Requires a int has its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMinValue(int val, string key = "",string message = "{0} should be {1}")
    {
        if (val != int.MinValue)
            AddNotification(key, string.Format(message, key, int.MinValue));

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a int has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMinValue(int val, string key = "",string message = "{0} should not be {1}")
    {
        if (val == int.MinValue)
            AddNotification(key, string.Format(message, key, int.MinValue));

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a int has its max value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsMaxValue(int val, string key = "",string message = "{0} should be {1}")
    {
        if (val != int.MaxValue)
            AddNotification(key, string.Format(message, key, int.MaxValue));

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a int has not its min value
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotMaxValue(int val, string key = "",string message = "{0} should not be {1}")
    {
        if (val == int.MaxValue)
            AddNotification(key, string.Format(message, key, int.MinValue));

        return this;
    }

    #endregion

    #region IsBetween

    /// <summary>
    /// Requires a int is between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsBetween(int val, int start, int end, string key,
        string message = "{0} should be between {1} and {2}")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a int is not between
    /// </summary>
    /// <param name="val"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotBetween(int val, int start, int end, string key,
        string message = "{0} should not be between {1} and {2}")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, string.Format(message, key, start, end));

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a int
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(int val, IEnumerable<int> list, string key,
        string message = "{0} should contains the value {1}")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list does not contains a int
    /// </summary>
    /// <param name="val"></param>
    /// <param name="list"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(int val, IEnumerable<int> list, string key,
        string message = "{0} should not contains the value {1}")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion
}