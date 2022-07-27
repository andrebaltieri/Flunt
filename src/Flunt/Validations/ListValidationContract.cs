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
    public Contract IsEmpty<TList>(IEnumerable<TList> val, string key, string message = "List should be empty")
    {
        if (val.Any())
            AddNotification(key, message);

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
        string message = "List should contains at least one element")
    {
        if (val.Any() == false)
            AddNotification(key, message);

        return this;
    }
}