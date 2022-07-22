﻿namespace Flunt.Validations;

public partial class Contract
{
    #region IsFalse

    /// <summary>
    /// Requires that a bool is false
    /// </summary>
    /// <param name="val">bool</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsFalse(bool val, string key, string message = "This should be false")
    {
        if (val)
            AddNotification(key, message);

        return this;
    }

    #endregion

    #region IsTrue

    /// <summary>
    /// Requires that a bool is true
    /// </summary>
    /// <param name="val">bool</param>
    /// <param name="key">Key or Property Name</param>
    /// <param name="message">Custom error message</param>
    /// <returns></returns>
    public Contract IsTrue(bool val, string key, string message = "This should be true")
    {
        if (val == false)
            AddNotification(key, message);

        return this;
    }

    #endregion
}