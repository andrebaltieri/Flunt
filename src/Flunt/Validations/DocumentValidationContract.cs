namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a string is a passport number
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsPassport(string? val, string key = "", string message = "Invalid Passport number")
        => Matches(val ?? string.Empty, @"^(?!^0+$)[a-zA-Z0-9]{3,20}$", key, message);
}