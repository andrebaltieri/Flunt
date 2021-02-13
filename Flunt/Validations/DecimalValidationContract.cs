using System.Collections.Generic;
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




        public void IsMinValue(decimal val, string key, string message) { }

        public void IsNotMinValue(decimal val, string key, string message) { }

        public void IsMaxValue(decimal val, string key, string message) { }

        public void IsNotMaxValue(decimal val, string key, string message) { }




        public void AreEquals(decimal val, decimal comparer, string key, string message) { }
        public void AreEquals(decimal val, double comparer, string key, string message) { }
        public void AreEquals(decimal val, float comparer, string key, string message) { }
        public void AreEquals(decimal val, int comparer, string key, string message) { }

        public void AreNotEquals(decimal val, decimal comparer, string key, string message) { }
        public void AreNotEquals(decimal val, double comparer, string key, string message) { }
        public void AreNotEquals(decimal val, float comparer, string key, string message) { }
        public void AreNotEquals(decimal val, int comparer, string key, string message) { }

        public void IsNull(decimal val, string key, string message) { }

        public void IsNotNull(decimal val, string key, string message) { }

        public void IsBetween(decimal val, decimal start, decimal end, string key, string message) { }
        public void IsBetween(decimal val, double start, double end, string key, string message) { }
        public void IsBetween(decimal val, float start, float end, string key, string message) { }
        public void IsBetween(decimal val, int start, int end, string key, string message) { }

        public void IsNotBetween(decimal val, decimal start, decimal end, string key, string message) { }
        public void IsNotBetween(decimal val, double start, double end, string key, string message) { }
        public void IsNotBetween(decimal val, float start, float end, string key, string message) { }
        public void IsNotBetween(decimal val, int start, int end, string key, string message) { }

        public void Contains(decimal val, IEnumerable<decimal> list, string key, string message) { }
        public void Contains(decimal val, IEnumerable<double> list, string key, string message) { }
        public void Contains(decimal val, IEnumerable<float> list, string key, string message) { }
        public void Contains(decimal val, IEnumerable<int> list, string key, string message) { }

        public void NotContains(decimal val, IEnumerable<decimal> list, string key, string message) { }
        public void NotContains(decimal val, IEnumerable<double> list, string key, string message) { }
        public void NotContains(decimal val, IEnumerable<float> list, string key, string message) { }
        public void NotContains(decimal val, IEnumerable<int> list, string key, string message) { }
    }
}
