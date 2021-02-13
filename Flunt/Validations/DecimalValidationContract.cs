using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, decimal comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, decimal comparer, string key, string message)
        {
            if (val <= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, double comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, double comparer, string key, string message) =>
            IsGreaterThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, float comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, float comparer, string key, string message) =>
            IsGreaterThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, ContractLocalization.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(decimal val, int comparer, string key, string message) =>
            IsGreaterThan(val, (decimal)comparer, key, message);
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, decimal comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, decimal comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, double comparer, string key) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, double comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, float comparer, string key) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, float comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(decimal val, int comparer, string key, string message) =>
            IsGreaterOrEqualsThan(val, (decimal)comparer, key, message);
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, decimal comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, decimal comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, double comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, double comparer, string key, string message) =>
            IsLowerThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, float comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, float comparer, string key, string message) =>
            IsLowerThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, ContractLocalization.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(decimal val, int comparer, string key, string message) =>
            IsLowerThan(val, (decimal)comparer, key, message);
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, decimal comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, decimal comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, double comparer, string key) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, double comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, float comparer, string key) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, float comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, ContractLocalization.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a decimal is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Message</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(decimal val, int comparer, string key, string message) =>
            IsLowerOrEqualsThan(val, (decimal)comparer, key, message);
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires a decimal has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(decimal val, string key) =>
            IsMinValue(val, key, ContractLocalization.IsMinValueErrorMessage(key, decimal.MinValue.ToString()));

        /// <summary>
        /// Requires a decimal has its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMinValue(decimal val, string key, string message)
        {
            if (val != decimal.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires a decimal has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(decimal val, string key) =>
            IsNotMinValue(val, key, ContractLocalization.IsNotMinValueErrorMessage(key, decimal.MinValue.ToString()));

        /// <summary>
        /// Requires a decimal has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(decimal val, string key, string message)
        {
            if (val == decimal.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires a decimal has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(decimal val, string key) =>
            IsMaxValue(val, key, ContractLocalization.IsMaxValueErrorMessage(key, decimal.MaxValue.ToString()));

        /// <summary>
        /// Requires a decimal has its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(decimal val, string key, string message)
        {
            if (val != decimal.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires a decimal has not its max value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(decimal val, string key) =>
            IsNotMaxValue(val, key, ContractLocalization.IsNotMaxValueErrorMessage(key, decimal.MaxValue.ToString()));

        /// <summary>
        /// Requires a decimal has not its min value
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(decimal val, string key, string message)
        {
            if (val == decimal.MaxValue)
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
        public Contract<T> AreEquals(decimal val, decimal comparer, string key) =>
            AreEquals(val, comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, decimal comparer, string key, string message)
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
        public Contract<T> AreEquals(decimal val, int comparer, string key) =>
            AreEquals(val, (decimal)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, int comparer, string key, string message) =>
            AreEquals(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, float comparer, string key) =>
            AreEquals(val, (decimal)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, float comparer, string key, string message) =>
            AreEquals(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, double comparer, string key) =>
            AreEquals(val, (decimal)comparer, key, ContractLocalization.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(decimal val, double comparer, string key, string message) =>
            AreEquals(val, (decimal)comparer, key, message);
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
        public Contract<T> AreNotEquals(decimal val, decimal comparer, string key) =>
            AreNotEquals(val, comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, decimal comparer, string key, string message)
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
        public Contract<T> AreNotEquals(decimal val, int comparer, string key) =>
            AreNotEquals(val, (decimal)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, int comparer, string key, string message) =>
            AreNotEquals(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, float comparer, string key) =>
            AreNotEquals(val, (decimal)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, float comparer, string key, string message) =>
            AreNotEquals(val, (decimal)comparer, key, message);

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, double comparer, string key) =>
            AreNotEquals(val, (decimal)comparer, key, ContractLocalization.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two decimals are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(decimal val, double comparer, string key, string message) =>
            AreNotEquals(val, (decimal)comparer, key, message);
        #endregion

        #region IsNull
        /// <summary>
        /// Requires a decimal is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(decimal? val, string key) =>
            IsNull(val, key, ContractLocalization.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a decimal is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(decimal? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires a decimal is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(decimal? val, string key) =>
            IsNotNull(val, key, ContractLocalization.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a decimal is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(decimal? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, decimal start, decimal end, string key) =>
            IsBetween(val, start, end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, decimal start, decimal end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, int start, int end, string key) =>
            IsBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, int start, int end, string key, string message) =>
            IsBetween(val, (decimal)start, (decimal)end, key, message);

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, float start, float end, string key) =>
            IsBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, float start, float end, string key, string message) =>
            IsBetween(val, (decimal)start, (decimal)end, key, message);

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, double start, double end, string key) =>
            IsBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBetween(decimal val, double start, double end, string key, string message) =>
            IsBetween(val, (decimal)start, (decimal)end, key, message);
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, decimal start, decimal end, string key) =>
            IsNotBetween(val, start, end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, decimal start, decimal end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, int start, int end, string key) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, int start, int end, string key, string message) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, message);

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, float start, float end, string key) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, float start, float end, string key, string message) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, message);

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, double start, double end, string key) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, ContractLocalization.IsNotBetweenErrorMessage(key, start.ToString(ContractLocalization.DateTimeFormat), end.ToString(ContractLocalization.DateTimeFormat)));

        /// <summary>
        /// Requires a decimal is not between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(decimal val, double start, double end, string key, string message) =>
            IsNotBetween(val, (decimal)start, (decimal)end, key, message);
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains a decimal
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(decimal val, IEnumerable<decimal> list, string key) =>
            Contains(val, list, key, ContractLocalization.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains a decimal
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(decimal val, IEnumerable<decimal> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list does not contains a decimal
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(decimal val, IEnumerable<decimal> list, string key) =>
            NotContains(val, list, key, ContractLocalization.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list does not contains a decimal
        /// </summary>
        /// <param name="val"></param>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(decimal val, IEnumerable<decimal> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
