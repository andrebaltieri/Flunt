namespace Flunt.Validations;

public partial class Contract
{
    private const string EmailRegexPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

    /// <summary>
    /// Requires a string is an email
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsEmail(string val, string key = "", string message = "Invalid E-mail")
        => Matches(val, EmailRegexPattern, key, message);

    /// <summary>
    /// Requires a string is an email or empty
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsEmailOrEmpty(string val, string key = "", string message = "Invalid E-mail")
        => string.IsNullOrEmpty(val) ? this : IsEmail(val, key, message);

    /// <summary>
    /// Requires a string is not an email
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotEmail(string val, string key = "", string message = "String should not be an email")
        => NotMatches(val, EmailRegexPattern, key, message);
}