using System.Text.RegularExpressions;

namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a string is a Credit Card number
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsCreditCard(string val, string key = "",string message = "Invalid Credit Card number")
    {
        val = Regex.Replace(val, @"[^0-9]+", "");

        if (string.IsNullOrWhiteSpace(val))
        {
            AddNotification(key, message);
            return this;
        }

        var even = false;
        var checksum = 0;

        foreach (var digit in val.ToCharArray().Reverse())
        {
            if (!char.IsDigit(digit))
            {
                AddNotification(val, message);
                return this;
            }

            var value = (digit - '0') * (even ? 2 : 1);
            even = !even;

            while (value > 0)
            {
                checksum += value % 10;
                value /= 10;
            }
        }

        if (checksum % 10 != 0)
            AddNotification(key, message);

        return this;
    }
}