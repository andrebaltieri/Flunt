namespace Flunt.Validations;

public partial class Contract
{
    #region IsGreaterThan

    /// <summary>
    /// Requires a date is greater than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsGreaterThan(DateTime val, DateTime comparer, string key,
        string message = "Date should be greater than")
    {
        if (val <= comparer)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsGreaterOrEqualsThan

    /// <summary>
    /// Requires a date is greater or equals than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsGreaterOrEqualsThan(DateTime val, DateTime comparer, string key,
        string message = "Date should be greater or equals than")
    {
        if (val < comparer)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsLowerThan

    /// <summary>
    /// Requires a date is lower than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsLowerThan(DateTime val, DateTime comparer, string key,
        string message = "Date should be lower than")
    {
        if (val >= comparer)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsLowerOrEqualsThan

    /// <summary>
    /// Requires a date is lower or equals than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsLowerOrEqualsThan(DateTime val, DateTime comparer, string key,
        string message = "Date should be lower or equals than")
    {
        if (val > comparer)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNull

    /// <summary>
    /// Requires a date is null
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNull(DateTime? val, string key, string message = "Date should be null")
    {
        if (val != null)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsNotNull

    /// <summary>
    /// Requires a date is not null
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotNull(DateTime? val, string key, string message = "Date should not be null")
    {
        if (val == null)
            AddNotification(key, message);

        return this;
    }

    #endregion

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
    public Contract IsBetween(DateTime val, DateTime start, DateTime end, string key,
        string message = "Date should be between range")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, message);

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
    public Contract IsNotBetween(DateTime val, DateTime start, DateTime end, string key,
        string message = "Date should not be between range")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, message);

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
    public Contract IsMinValue(DateTime val, string key, string message = "Date should be the default min value")
    {
        if (val != DateTime.MinValue)
            AddNotification(key, message);

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
    public Contract IsNotMinValue(DateTime val, string key, string message = "Date should not be the default min value")
    {
        if (val == DateTime.MinValue)
            AddNotification(key, message);

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
    public Contract IsMaxValue(DateTime val, string key, string message = "Date should be the default max value")
    {
        if (val != DateTime.MaxValue)
            AddNotification(key, message);

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
    public Contract IsNotMaxValue(DateTime val, string key, string message = "Date should not be the default max value")
    {
        if (val == DateTime.MaxValue)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region AreEquals

    /// <summary>
    /// Require dates are equals
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="comparer">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract AreEquals(DateTime val, DateTime comparer, string key, string message = "Dates should be equals")
    {
        if (val != comparer)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region AreNotEquals

    /// <summary>
    /// Requires two dates are not equals
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="comparer">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract AreNotEquals(DateTime val, DateTime comparer, string key,
        string message = "Dates should be not be equals")
    {
        if (val == comparer)
            AddNotification(key, message);

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
    public Contract Contains(DateTime val, IEnumerable<DateTime> list, string key,
        string message = "Date should contain value")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, message);

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
    public Contract NotContains(DateTime val, IEnumerable<DateTime> list, string key,
        string message = "Date should not contain value")
    {
        if (list.Any(x => x == val) == true)
            AddNotification(key, message);

        return this;
    }

    #endregion
}