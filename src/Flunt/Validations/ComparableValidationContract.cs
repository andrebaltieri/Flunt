namespace Flunt.Validations;

public partial class Contract
{
    #region AreEquals

    /// <summary>
    /// Requires a values are equals
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract AreEquals<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should be equals to {2}")
        where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) != 0)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion

    #region AreNotEquals

    /// <summary>
    /// Requires a values are not equals
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract AreNotEquals<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should not be equals to {2}")
        where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) == 0)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion

    #region IsGreaterThan

    /// <summary>
    /// Requires a value is greater than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsGreaterThan<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should be greater than {2}") where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) != 1)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion

    #region IsGreaterOrEqualsThan

    /// <summary>
    /// Requires a value is greater or equals than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsGreaterOrEqualsThan<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should be greater or equals than {2}") where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) < 0)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion

    #region IsLowerThan

    /// <summary>
    /// Requires a value is lower than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsLowerThan<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should be lower than {2}")
        where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) != -1)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion

    #region IsLowerOrEqualsThan

    /// <summary>
    /// Requires a value is lower or equals than
    /// </summary>
    /// <param name="val">val</param>
    /// <param name="comparer">comparer</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsLowerOrEqualsThan<T>(T val, T comparer, string key = "Comparer",
        string message = "{0}({1}) should be lower or equals than {2}") where T : IEquatable<T>
    {
        if (Comparer<T>.Default.Compare(val, comparer) > 0)
            AddNotification(key, string.Format(message, key, val, comparer));

        return this;
    }

    #endregion
}