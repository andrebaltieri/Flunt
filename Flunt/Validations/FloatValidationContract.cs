using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, float comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, float comparer, string key, string message)
        {
            if (val <= (float)comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, decimal comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, decimal comparer, string key, string message) =>
            IsGreaterThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, double comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, double comparer, string key, string message) =>
            IsGreaterThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(float val, int comparer, string key, string message) =>
            IsGreaterThan(val, (float)comparer, key, message);
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, float comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, float comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, decimal comparer, string key) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, decimal comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, double comparer, string key) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, double comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(float val, int comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (float)comparer, key, message);
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, float comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, float comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, decimal comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, decimal comparer, string key, string message) =>
            IsLowerThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, double comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, double comparer, string key, string message) =>
            IsLowerThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(float val, int comparer, string key, string message) =>
            IsLowerThan(val, (float)comparer, key, message);
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, float comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, float comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, decimal comparer, string key) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, decimal comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, double comparer, string key) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, double comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, message);

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a float is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(float val, int comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (float)comparer, key, message);
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires a float has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(float val, string key) =>
            IsMinValue(val, key, ContractLocalization.IsMinValueErrorMessage(key, decimal.MinValue.ToString()));

        /// <summary>
        /// Requires a float has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(float val, string key, string message)
        {
            if (val != float.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires a float has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(float val, string key) =>
            IsNotMinValue(val, key, ContractLocalization.IsNotMinValueErrorMessage(key, decimal.MinValue.ToString()));

        /// <summary>
        /// Requires a float has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(float val, string key, string message)
        {
            if (val == float.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires a float has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(float val, string key) =>
            IsMaxValue(val, key, ContractLocalization.IsMaxValueErrorMessage(key, decimal.MaxValue.ToString()));

        /// <summary>
        /// Requires a float has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(float val, string key, string message)
        {
            if (val != float.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires a float has not its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(float val, string key) =>
            IsNotMaxValue(val, key, ContractLocalization.IsNotMaxValueErrorMessage(key, decimal.MaxValue.ToString()));

        /// <summary>
        /// Requires a float has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(float val, string key, string message)
        {
            if (val == float.MaxValue)
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
        public Contract<T> AreEquals(float val, float comparer, string key) =>
            AreEquals(val, comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, float comparer, string key, string message)
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
        public Contract<T> AreEquals(float val, int comparer, string key) =>
            AreEquals(val, (float)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, int comparer, string key, string message) =>
            AreEquals(val, (float)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, double comparer, string key) =>
            AreEquals(val, (float)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, double comparer, string key, string message) =>
            AreEquals(val, (float)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, decimal comparer, string key) =>
            AreEquals(val, (float)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(float val, decimal comparer, string key, string message) =>
            AreEquals(val, (float)comparer, key, message);
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
        public Contract<T> AreNotEquals(float val, float comparer, string key) =>
            AreNotEquals(val, comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, float comparer, string key, string message)
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
        public Contract<T> AreNotEquals(float val, int comparer, string key) =>
            AreNotEquals(val, (float)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, int comparer, string key, string message) =>
            AreNotEquals(val, (float)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, double comparer, string key) =>
            AreNotEquals(val, (float)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, double comparer, string key, string message) =>
            AreNotEquals(val, (float)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, decimal comparer, string key) =>
            AreNotEquals(val, (float)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(float val, decimal comparer, string key, string message) =>
            AreNotEquals(val, (float)comparer, key, message);
        #endregion

        #region IsNull
        /// <summary>
        /// Requires a float is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(float? val, string key) =>
            IsNull(val, key, ContractLocalization.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a float is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(float? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires a float is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(float? val, string key) =>
            IsNotNull(val, key, ContractLocalization.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a float is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(float? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, float start, float end, string key) =>
            IsBetween(val, start, end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, float start, float end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, int start, int end, string key) =>
            IsBetween(val, (float)start, (float)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, int start, int end, string key, string message) =>
            IsBetween(val, (float)start, (float)end, key, message);

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, double start, double end, string key) =>
            IsBetween(val, (float)start, (float)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, double start, double end, string key, string message) =>
            IsBetween(val, (float)start, (float)end, key, message);

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, decimal start, decimal end, string key) =>
            IsBetween(val, (float)start, (float)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(float val, decimal start, decimal end, string key, string message) =>
            IsBetween(val, (float)start, (float)end, key, message);
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, float start, float end, string key) =>
            IsNotBetween(val, start, end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, float start, float end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, int start, int end, string key) =>
            IsNotBetween(val, (float)start, (float)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, int start, int end, string key, string message) =>
            IsNotBetween(val, (float)start, (float)end, key, message);

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, double start, double end, string key) =>
            IsNotBetween(val, (float)start, (float)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, double start, double end, string key, string message) =>
            IsNotBetween(val, (float)start, (float)end, key, message);

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, decimal start, decimal end, string key) =>
            IsNotBetween(val, (float)start, (float)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a float is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(float val, decimal start, decimal end, string key, string message) =>
            IsNotBetween(val, (float)start, (float)end, key, message);
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains a float
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(float val, IEnumerable<float> list, string key) =>
            Contains(val, list, key, ContractLocalization.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains a float
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(float val, IEnumerable<float> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list does not contains a float
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(float val, IEnumerable<float> list, string key) =>
            NotContains(val, list, key, ContractLocalization.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list does not contains a float
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(float val, IEnumerable<float> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
