namespace Flunt.Validations;

public partial class Contract
{
    #region IsBetween

    /// <summary>
    /// Requires a date is between
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="start">start date</param>
    /// <param name="end">end date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsBetween(DateTime val, DateTime start, DateTime end, string key = "",
        string message = "{0} should be between {1} and {2}")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, string.Format(message, val, start, end));

        return this;
    }

    #endregion

    #region IsNotBetween

    /// <summary>
    /// Requires a date is not between
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="start">start date</param>
    /// <param name="end">end date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsNotBetween(DateTime val, DateTime start, DateTime end, string key = "",
        string message = "{0} should not be between {1} and {2}")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, string.Format(message, val, start, end));

        return this;
    }

    #endregion

    #region IsMinValue

    /// <summary>
    /// Requires a date is min value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsMinValue(DateTime val, string key = "", string message = "{0} should be min value")
    {
        if (val != DateTime.MinValue)
            AddNotification(key, string.Format(message, val));

        return this;
    }

    #endregion

    #region IsNotMinValue

    /// <summary>
    /// Requires a date is not min value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotMinValue(DateTime val, string key = "", string message = "{0} should not be min value")
    {
        if (val == DateTime.MinValue)
            AddNotification(key, string.Format(message, val));

        return this;
    }

    #endregion

    #region IsMaxValue

    /// <summary>
    /// Requires a date is max value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsMaxValue(DateTime val, string key = "", string message = "{0} should be max value")
    {
        if (val != DateTime.MaxValue)
            AddNotification(key, string.Format(message, val));

        return this;
    }

    #endregion

    #region IsNotMaxValue

    /// <summary>
    /// Requires a date is not max value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotMaxValue(DateTime val, string key = "", string message = "{0} should not be max value")
    {
        if (val == DateTime.MaxValue)
            AddNotification(key, string.Format(message, val));

        return this;
    }

    #endregion

    #region Contains

    /// <summary>
    /// Requires a list contains a date
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="list">list of dates</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract Contains(DateTime val, IEnumerable<DateTime> list, string key = "",
        string message = "{0} should contain {1}")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion

    #region NotContains

    /// <summary>
    /// Requires a list not contains a date
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="list">list of dates</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract NotContains(DateTime val, IEnumerable<DateTime> list, string key = "",
        string message = "{0} should not contain {1}")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    #endregion
}