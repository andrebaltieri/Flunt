using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, int comparer, string key, string message)
        {
            if (val <= (int)comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, decimal comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, decimal comparer, string key, string message) =>
            IsGreaterThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, double comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, double comparer, string key, string message) =>
            IsGreaterThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, float comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, float comparer, string key, string message) =>
            IsGreaterThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, long comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(int val, long comparer, string key, string message) =>
            IsGreaterThan(val, (int)comparer, key, message);
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, int comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, decimal comparer, string key) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, decimal comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, double comparer, string key) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, double comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, float comparer, string key) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, float comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, long comparer, string key) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(int val, long comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (int)comparer, key, message);
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, int comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, decimal comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, decimal comparer, string key, string message) =>
            IsLowerThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, double comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, double comparer, string key, string message) =>
            IsLowerThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, float comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, float comparer, string key, string message) =>
            IsLowerThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, long comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(int val, long comparer, string key, string message) =>
            IsLowerThan(val, (int)comparer, key, message);
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, int comparer, string key, string message)
        {
            if (val > comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, decimal comparer, string key) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, decimal comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, double comparer, string key) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, double comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, float comparer, string key) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, float comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, message);

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, long comparer, string key) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires an int is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(int val, long comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (int)comparer, key, message);
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires an int has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(int val, string key) =>
            IsMinValue(val, key, FluntErrorMessages.IsMinValueErrorMessage(key, int.MinValue.ToString()));

        /// <summary>
        /// Requires an int has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(int val, string key, string message)
        {
            if (val != int.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires an int has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(int val, string key) =>
            IsNotMinValue(val, key, FluntErrorMessages.IsNotMinValueErrorMessage(key, int.MinValue.ToString()));

        /// <summary>
        /// Requires an int has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(int val, string key, string message)
        {
            if (val == int.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires an int has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(int val, string key) =>
            IsMaxValue(val, key, FluntErrorMessages.IsMaxValueErrorMessage(key, int.MaxValue.ToString()));

        /// <summary>
        /// Requires an int has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(int val, string key, string message)
        {
            if (val != int.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires an int has not its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(int val, string key) =>
            IsNotMaxValue(val, key, FluntErrorMessages.IsNotMaxValueErrorMessage(key, int.MaxValue.ToString()));

        /// <summary>
        /// Requires an int has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(int val, string key, string message)
        {
            if (val == int.MaxValue)
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
        public Contract<T> AreEquals(int val, int comparer, string key) =>
            AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, int comparer, string key, string message)
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
        public Contract<T> AreEquals(int val, float comparer, string key) =>
            AreEquals(val, (int)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, float comparer, string key, string message) =>
            AreEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, double comparer, string key) =>
            AreEquals(val, (int)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, double comparer, string key, string message) =>
            AreEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, decimal comparer, string key) =>
            AreEquals(val, (int)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, decimal comparer, string key, string message) =>
            AreEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, long comparer, string key) =>
            AreEquals(val, (int)comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(int val, long comparer, string key, string message) =>
            AreEquals(val, (int)comparer, key, message);
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
        public Contract<T> AreNotEquals(int val, int comparer, string key) =>
            AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, int comparer, string key, string message)
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
        public Contract<T> AreNotEquals(int val, float comparer, string key) =>
            AreNotEquals(val, (int)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, float comparer, string key, string message) =>
            AreNotEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, double comparer, string key) =>
            AreNotEquals(val, (int)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, double comparer, string key, string message) =>
            AreNotEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, decimal comparer, string key) =>
            AreNotEquals(val, (int)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, decimal comparer, string key, string message) =>
            AreNotEquals(val, (int)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, long comparer, string key) =>
            AreNotEquals(val, (int)comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(int val, long comparer, string key, string message) =>
            AreNotEquals(val, (int)comparer, key, message);
        #endregion

        #region IsNull
        /// <summary>
        /// Requires an int is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(int? val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires an int is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(int? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires an int is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(int? val, string key) =>
            IsNotNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires an int is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(int? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, int start, int end, string key) =>
            IsBetween(val, start, end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, int start, int end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, float start, float end, string key) =>
            IsBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, float start, float end, string key, string message) =>
            IsBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, double start, double end, string key) =>
            IsBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, double start, double end, string key, string message) =>
            IsBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, decimal start, decimal end, string key) =>
            IsBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, decimal start, decimal end, string key, string message) =>
            IsBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, long start, long end, string key) =>
            IsBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(int val, long start, long end, string key, string message) =>
            IsBetween(val, (int)start, (int)end, key, message);
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, int start, int end, string key) =>
            IsNotBetween(val, start, end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, int start, int end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, float start, float end, string key) =>
            IsNotBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, float start, float end, string key, string message) =>
            IsNotBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, double start, double end, string key) =>
            IsNotBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, double start, double end, string key, string message) =>
            IsNotBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, decimal start, decimal end, string key) =>
            IsNotBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, decimal start, decimal end, string key, string message) =>
            IsNotBetween(val, (int)start, (int)end, key, message);

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, long start, long end, string key) =>
            IsNotBetween(val, (int)start, (int)end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(FluntFormats.DateTimeFormat), end.ToString(FluntFormats.DateTimeFormat)));

        /// <summary>
        /// Requires an int is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(int val, long start, long end, string key, string message) =>
            IsNotBetween(val, (int)start, (int)end, key, message);
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains an int
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(int val, IEnumerable<int> list, string key) =>
            Contains(val, list, key, FluntErrorMessages.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains an int
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(int val, IEnumerable<int> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list does not contains an int
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(int val, IEnumerable<int> list, string key) =>
            NotContains(val, list, key, FluntErrorMessages.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list does not contains an int
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(int val, IEnumerable<int> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
