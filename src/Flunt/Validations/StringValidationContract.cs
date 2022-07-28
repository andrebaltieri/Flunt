using Flunt.Extensions;

namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a string is null or empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNullOrEmpty(string val, string key = "",string message = "{0} should be null or empty")
    {
        if (string.IsNullOrEmpty(val) == false)
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a string is not null or empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotNullOrEmpty(string val, string key = "",string message = "{0} should not be null or empty")
    {
        if (string.IsNullOrEmpty(val))
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a string is null or white space
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNullOrWhiteSpace(string val, string key = "",string message = "{0} should be null or white space")
    {
        if (string.IsNullOrWhiteSpace(val) == false)
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a string is not null or white space
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotNullOrWhiteSpace(string val, string key,
        string message = "{0} should not be null or white space")
    {
        if (string.IsNullOrWhiteSpace(val))
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires two strings are equals
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <param name="comparison"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract AreEquals(string val, string comparer, StringComparison comparison, string key,
        string message = "{0} and {1} should be equals")
    {
        if (!val.Equals(comparer, comparison))
            AddNotification(key, string.Format(message, val, comparer));

        return this;
    }

    /// <summary>
    /// Requires two strings are not equals
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <param name="comparison"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract AreNotEquals(string val, string comparer, StringComparison comparison, string key,
        string message = "{0} and {1} should not be equals")
    {
        if (val.Equals(comparer, comparison))
            AddNotification(key, string.Format(message, val, comparer));

        return this;
    }

    /// <summary>
    /// Requires a list contains a string
    /// </summary>
    /// <param name="list"></param>
    /// <param name="val"></param>
    /// <param name="comparison"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Contains(IEnumerable<string> list, string val, StringComparison comparison, string key,
        string message = "{0} should contains the value {1}")
    {
        if (!list.Contains(val, comparison))
            AddNotification(key, string.Format(message, key, val));

        return this;
    }

    /// <summary>
    /// Requires a list does not contains a string
    /// </summary>
    /// <param name="list"></param>
    /// <param name="val"></param>
    /// <param name="comparison"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotContains(IEnumerable<string> list, string val, StringComparison comparison, string key,
        string message = "{0} should not contains the value {1}")
    {
        if (list.Contains(val, comparison))
            AddNotification(key, string.Format(message, key, val));

        return this;
    }
}