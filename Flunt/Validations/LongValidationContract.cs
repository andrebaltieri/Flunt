using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, long comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, long comparer, string key, string message)
        {
            if (val <= (long)comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, decimal comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, decimal comparer, string key, string message) =>
            IsGreaterThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, double comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, double comparer, string key, string message) =>
            IsGreaterThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, float comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, float comparer, string key, string message) =>
            IsGreaterThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(long val, int comparer, string key, string message) =>
            IsGreaterThan(val, (long)comparer, key, message);
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, long comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, long comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, decimal comparer, string key) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, decimal comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, double comparer, string key) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, double comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, float comparer, string key) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, float comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(long val, int comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (long)comparer, key, message);
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, long comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, long comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, decimal comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, decimal comparer, string key, string message) =>
            IsLowerThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, double comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, double comparer, string key, string message) =>
            IsLowerThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, float comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, float comparer, string key, string message) =>
            IsLowerThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(long val, int comparer, string key, string message) =>
            IsLowerThan(val, (long)comparer, key, message);
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, long comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, long comparer, string key, string message)
        {
            if (val >comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, decimal comparer, string key) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, decimal comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, double comparer, string key) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, double comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, float comparer, string key) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, float comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, message);

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a long is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(long val, int comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (long)comparer, key, message);
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires a long has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(long val, string key) =>
            IsMinValue(val, key, FluntErrorMessages.IsMinValueErrorMessage(key, long.MinValue.ToString()));

        /// <summary>
        /// Requires a long has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(long val, string key, string message)
        {
            if (val != long.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires a long has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(long val, string key) =>
            IsNotMinValue(val, key, FluntErrorMessages.IsNotMinValueErrorMessage(key, long.MinValue.ToString()));

        /// <summary>
        /// Requires a long has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(long val, string key, string message)
        {
            if (val == long.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires a long has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(long val, string key) =>
            IsMaxValue(val, key, FluntErrorMessages.IsMaxValueErrorMessage(key, long.MaxValue.ToString()));

        /// <summary>
        /// Requires a long has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(long val, string key, string message)
        {
            if (val != long.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires a long has not its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(long val, string key) =>
            IsNotMaxValue(val, key, FluntErrorMessages.IsNotMaxValueErrorMessage(key, long.MaxValue.ToString()));

        /// <summary>
        /// Requires a long has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(long val, string key, string message)
        {
            if (val == long.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region AreEquals
        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, long comparer, string key) =>
            AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, long comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, float comparer, string key) =>
            AreEquals(val, (long)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, float comparer, string key, string message) =>
            AreEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, double comparer, string key) =>
            AreEquals(val, (long)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, double comparer, string key, string message) =>
            AreEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, decimal comparer, string key) =>
            AreEquals(val, (long)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, decimal comparer, string key, string message) =>
            AreEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, int comparer, string key) =>
            AreEquals(val, (long)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(long val, int comparer, string key, string message) =>
            AreEquals(val, (long)comparer, key, message);
        #endregion

        #region AreNotEquals
        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, long comparer, string key) =>
            AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, long comparer, string key, string message)
        {
            if (val == comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, float comparer, string key) =>
            AreNotEquals(val, (long)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, float comparer, string key, string message) =>
            AreNotEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, double comparer, string key) =>
            AreNotEquals(val, (long)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, double comparer, string key, string message) =>
            AreNotEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, decimal comparer, string key) =>
            AreNotEquals(val, (long)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, decimal comparer, string key, string message) =>
            AreNotEquals(val, (long)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, int comparer, string key) =>
            AreNotEquals(val, (long)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(long val, int comparer, string key, string message) =>
            AreNotEquals(val, (long)comparer, key, message);
        #endregion

        #region IsNull
        /// <summary>
        /// Requires a long is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(long? val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a long is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(long? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires a long is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(long? val, string key) =>
            IsNotNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a long is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(long? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, long start, long end, string key) =>
            IsBetween(val, start, end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, long start, long end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, float start, float end, string key) =>
            IsBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, float start, float end, string key, string message) =>
            IsBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, double start, double end, string key) =>
            IsBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, double start, double end, string key, string message) =>
            IsBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, decimal start, decimal end, string key) =>
            IsBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, decimal start, decimal end, string key, string message) =>
            IsBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, int start, int end, string key) =>
            IsBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(long val, int start, int end, string key, string message) =>
            IsBetween(val, (long)start, (long)end, key, message);
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, long start, long end, string key) =>
            IsNotBetween(val, start, end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, long start, long end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, float start, float end, string key) =>
            IsNotBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, float start, float end, string key, string message) =>
            IsNotBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, double start, double end, string key) =>
            IsNotBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, double start, double end, string key, string message) =>
            IsNotBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, decimal start, decimal end, string key) =>
            IsNotBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, decimal start, decimal end, string key, string message) =>
            IsNotBetween(val, (long)start, (long)end, key, message);

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, int start, int end, string key) =>
            IsNotBetween(val, (long)start, (long)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires a long is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(long val, int start, int end, string key, string message) =>
            IsNotBetween(val, (long)start, (long)end, key, message);
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains a long
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(long val, IEnumerable<long> list, string key) =>
            Contains(val, list, key, FluntErrorMessages.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains a long
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(long val, IEnumerable<long> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list does not contains a long
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(long val, IEnumerable<long> list, string key) =>
            NotContains(val, list, key, FluntErrorMessages.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list does not contains a long
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(long val, IEnumerable<long> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
