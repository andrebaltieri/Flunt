namespace Flunt.Validations;

public partial class Contract
{
    /// <summary>
    /// Requires a list contains no elements
    /// </summary>
    /// <typeparam name="TList"></typeparam>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsEmpty<TList>(IEnumerable<TList> val, string key = "",string message = "{0} should be an empty list")
    {
        if (val.Any())
            AddNotification(key, string.Format(message, key));

        return this;
    }

    /// <summary>
    /// Requires a list contains at least one element
    /// </summary>
    /// <typeparam name="TList"></typeparam>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public Contract IsNotEmpty<TList>(IEnumerable<TList> val, string key,
        string message = "{0} should contains at least one element")
    {
        if (val.Any() == false)
            AddNotification(key, string.Format(message, key));

        return this;
    }
}