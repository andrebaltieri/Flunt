namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a date is between
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="start">start date</param>
    /// <param name="end">end date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key, string message = "Date should be between")
    {
        if ((val >= start && val <= end) == false)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a date is not between
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="start">start date</param>
    /// <param name="end">end date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Customer error message</param>
    /// <returns></returns>
    public Contract IsNotBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key, string message = "Date should not be between")
    {
        if ((val >= start && val <= end) == true)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a date is min value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsMinValue(TimeSpan val, string key, string message = "Date should be min value")
    {
        if (val != TimeSpan.MinValue)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a date is not min value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotMinValue(TimeSpan val, string key, string message = "Date should not be min value")
    {
        if (val == TimeSpan.MinValue)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a date is max value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsMaxValue(TimeSpan val, string key, string message = "Date should be max value")
    {
        if (val != TimeSpan.MaxValue)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a date is not max value
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsNotMaxValue(TimeSpan val, string key, string message = "Date should not be max value")
    {
        if (val == TimeSpan.MaxValue)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a list contains a date
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="list">list of dates</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract Contains(TimeSpan val, IEnumerable<TimeSpan> list, string key, string message = "List should contain a date")
    {
        if (list.Any(x => x == val) == false)
            AddNotification(key, message);

        return this;
    }

    /// <summary>
    /// Requires a list not contains a date
    /// </summary>
    /// <param name="val">date</param>
    /// <param name="list">list of dates</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract NotContains(TimeSpan val, IEnumerable<TimeSpan> list, string key, string message = "List should not contain a date")
    {
        if (list.Any(x => x == val))
            AddNotification(key, message);

        return this;
    }
}