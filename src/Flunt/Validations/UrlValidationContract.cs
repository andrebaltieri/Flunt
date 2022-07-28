namespace Flunt.Validations;

public partial class Contract
{
    private const string UrlRegexPattern =
        @"^(http|https):(\/\/www\.|\/\/www\.|\/\/|\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$|(http|https):(\/\/localhost:\d*|\/\/127\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\/.*)?$";

    /// <summary>
    /// Requires a string is an URL
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsUrl(string val, string key = "", string message = "String should be an URL") =>
        Matches(val, UrlRegexPattern, key, message);

    /// <summary>
    /// Requires a string is an URL or empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsUrlOrEmpty(string val, string key = "", string message = "String should be empty or an URL")
        => string.IsNullOrEmpty(val) ? this : Matches(val, UrlRegexPattern, key, message);

    /// <summary>
    /// Requires a string is not an URL
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotUrl(string val, string key = "", string message = "String should not be an URL") =>
        NotMatches(val, UrlRegexPattern, key, message);

    /// <summary>
    /// Requires a string is not an URL or is empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotUrlOrEmpty(string val, string key = "", string message = "String should be empty or not be an URL")
        => string.IsNullOrEmpty(val) ? this : NotMatches(val, UrlRegexPattern, key, message);
}