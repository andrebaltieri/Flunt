using System.Text.RegularExpressions;

namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a string matches a regex pattern
    /// </summary>
    /// <param name="val"></param>
    /// <param name="pattern"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract Matches(string val, string pattern, string key = "",string message = "{0} does not matches the pattern")
    {
        if (!Regex.IsMatch(val ?? "", pattern))
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a string not matches a regex pattern
    /// </summary>
    /// <param name="val"></param>
    /// <param name="pattern"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract NotMatches(string val, string pattern, string key,
        string message = "{0} should not matches the pattern")
    {
        if (Regex.IsMatch(val ?? "", pattern))
            AddNotification(key, string.Format(message, key));

        return this;
    }
}