using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, double comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, double comparer, string key, string message)
        {
            if (val <= (double)comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, decimal comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, decimal comparer, string key, string message) =>
            IsGreaterThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, float comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, float comparer, string key, string message) =>
            IsGreaterThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, int comparer, string key, string message) =>
            IsGreaterThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, long comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(double val, long comparer, string key, string message) =>
            IsGreaterThan(val, (double)comparer, key, message);
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, double comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, double comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, decimal comparer, string key) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, decimal comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, float comparer, string key) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, float comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, int comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, long comparer, string key) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(double val, long comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (double)comparer, key, message);
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, double comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, double comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, decimal comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, decimal comparer, string key, string message) =>
            IsLowerThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, float comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, float comparer, string key, string message) =>
            IsLowerThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, int comparer, string key, string message) =>
            IsLowerThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, long comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(double val, long comparer, string key, string message) =>
            IsLowerThan(val, (double)comparer, key, message);
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, double comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, double comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, decimal comparer, string key) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, decimal comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, float comparer, string key) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, float comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, int comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, message);

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, long comparer, string key) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a double is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(double val, long comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (double)comparer, key, message);
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires a double has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(double val, string key) =>
            IsMinValue(val, key, ContractLocalization.IsMinValueErrorMessage(key, double.MinValue.ToString()));

        /// <summary>
        /// Requires a double has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(double val, string key, string message)
        {
            if (val != double.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires a double has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(double val, string key) =>
            IsNotMinValue(val, key, ContractLocalization.IsNotMinValueErrorMessage(key, double.MinValue.ToString()));

        /// <summary>
        /// Requires a double has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(double val, string key, string message)
        {
            if (val == double.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires a double has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(double val, string key) =>
            IsMaxValue(val, key, ContractLocalization.IsMaxValueErrorMessage(key, double.MaxValue.ToString()));

        /// <summary>
        /// Requires a double has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(double val, string key, string message)
        {
            if (val != double.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires a double has not its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(double val, string key) =>
            IsNotMaxValue(val, key, ContractLocalization.IsNotMaxValueErrorMessage(key, double.MaxValue.ToString()));

        /// <summary>
        /// Requires a double has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(double val, string key, string message)
        {
            if (val == double.MaxValue)
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
        public Contract<T> AreEquals(double val, double comparer, string key) =>
            AreEquals(val, comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, double comparer, string key, string message)
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
        public Contract<T> AreEquals(double val, int comparer, string key) =>
            AreEquals(val, (double)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, int comparer, string key, string message) =>
            AreEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, float comparer, string key) =>
            AreEquals(val, (double)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, float comparer, string key, string message) =>
            AreEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, decimal comparer, string key) =>
            AreEquals(val, (double)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, decimal comparer, string key, string message) =>
            AreEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, long comparer, string key) =>
            AreEquals(val, (double)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(double val, long comparer, string key, string message) =>
            AreEquals(val, (double)comparer, key, message);
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
        public Contract<T> AreNotEquals(double val, double comparer, string key) =>
            AreNotEquals(val, comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, double comparer, string key, string message)
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
        public Contract<T> AreNotEquals(double val, int comparer, string key) =>
            AreNotEquals(val, (double)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, int comparer, string key, string message) =>
            AreNotEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, float comparer, string key) =>
            AreNotEquals(val, (double)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, float comparer, string key, string message) =>
            AreNotEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, decimal comparer, string key) =>
            AreNotEquals(val, (double)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, decimal comparer, string key, string message) =>
            AreNotEquals(val, (double)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, long comparer, string key) =>
            AreNotEquals(val, (double)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(double val, long comparer, string key, string message) =>
            AreNotEquals(val, (double)comparer, key, message);
        #endregion

        #region IsNull
        /// <summary>
        /// Requires a double is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(double? val, string key) =>
            IsNull(val, key, ContractLocalization.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a double is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(double? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires a double is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(double? val, string key) =>
            IsNotNull(val, key, ContractLocalization.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a double is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(double? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, double start, double end, string key) =>
            IsBetween(val, start, end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, double start, double end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, int start, int end, string key) =>
            IsBetween(val, (double)start, (double)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, int start, int end, string key, string message) =>
            IsBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, float start, float end, string key) =>
            IsBetween(val, (double)start, (double)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, float start, float end, string key, string message) =>
            IsBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, decimal start, decimal end, string key) =>
            IsBetween(val, (double)start, (double)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, decimal start, decimal end, string key, string message) =>
            IsBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, long start, long end, string key) =>
            IsBetween(val, (double)start, (double)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(double val, long start, long end, string key, string message) =>
            IsBetween(val, (double)start, (double)end, key, message);
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, double start, double end, string key) =>
            IsNotBetween(val, start, end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, double start, double end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, int start, int end, string key) =>
            IsNotBetween(val, (double)start, (double)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, int start, int end, string key, string message) =>
            IsNotBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, float start, float end, string key) =>
            IsNotBetween(val, (double)start, (double)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, float start, float end, string key, string message) =>
            IsNotBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, decimal start, decimal end, string key) =>
            IsNotBetween(val, (double)start, (double)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, decimal start, decimal end, string key, string message) =>
            IsNotBetween(val, (double)start, (double)end, key, message);

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, long start, long end, string key) =>
            IsNotBetween(val, (double)start, (double)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a double is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(double val, long start, long end, string key, string message) =>
            IsNotBetween(val, (double)start, (double)end, key, message);
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains a double
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(double val, IEnumerable<double> list, string key) =>
            Contains(val, list, key, ContractLocalization.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains a double
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(double val, IEnumerable<double> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list does not contains a double
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(double val, IEnumerable<double> list, string key) =>
            NotContains(val, list, key, ContractLocalization.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list does not contains a double
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(double val, IEnumerable<double> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
