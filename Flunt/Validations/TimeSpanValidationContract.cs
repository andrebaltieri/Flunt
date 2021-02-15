using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        #region IsGreaterThan
        /// <summary>
        /// Requires a date is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(TimeSpan val, TimeSpan comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a date is greater than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val <= comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        /// <summary>
        /// Requires a date is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(TimeSpan val, TimeSpan comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a date is greater or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val < comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsLowerThan
        /// <summary>
        /// Requires a date is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(TimeSpan val, TimeSpan comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a date is lower than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val >= comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        /// <summary>
        /// Requires a date is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(TimeSpan val, TimeSpan comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a date is lower or equals than
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="comparer">comparer</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val > comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNull
        /// <summary>
        /// Requires a date is null
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNull(TimeSpan? val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a date is null
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNull(TimeSpan? val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Requires a date is not null
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(TimeSpan? val, string key) =>
            IsNotNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a date is not null
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNotNull(TimeSpan? val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsBetween
        /// <summary>
        /// Requires a date is between
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key) =>
            IsBetween(val, start, end, key, FluntErrorMessages.IsBetweenErrorMessage(key, start.ToString(), end.ToString()));

        /// <summary>
        /// Requires a date is between
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key, string message)
        {
            if ((val >= start && val <= end) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotBetween
        /// <summary>
        /// Requires a date is not between
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key) =>
            IsNotBetween(val, start, end, key, FluntErrorMessages.IsNotBetweenErrorMessage(key, start.ToString(), end.ToString()));

        /// <summary>
        /// Requires a date is not between
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> IsNotBetween(TimeSpan val, TimeSpan start, TimeSpan end, string key, string message)
        {
            if ((val >= start && val <= end) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMinValue
        /// <summary>
        /// Requires a date is min value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsMinValue(TimeSpan val, string key) =>
            IsMinValue(val, key, FluntErrorMessages.IsMinValueErrorMessage(key, TimeSpan.MinValue.ToString()));


        /// <summary>
        /// Requires a date is min value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsMinValue(TimeSpan val, string key, string message)
        {
            if (val != TimeSpan.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMinValue
        /// <summary>
        /// Requires a date is not min value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(TimeSpan val, string key) =>
            IsNotMinValue(val, key, FluntErrorMessages.IsNotMinValueErrorMessage(key, TimeSpan.MinValue.ToString()));


        /// <summary>
        /// Requires a date is not min value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNotMinValue(TimeSpan val, string key, string message)
        {
            if (val == TimeSpan.MinValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsMaxValue
        /// <summary>
        /// Requires a date is max value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(TimeSpan val, string key) =>
            IsMaxValue(val, key, FluntErrorMessages.IsMaxValueErrorMessage(key, TimeSpan.MaxValue.ToString()));


        /// <summary>
        /// Requires a date is max value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsMaxValue(TimeSpan val, string key, string message)
        {
            if (val != TimeSpan.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region IsNotMaxValue
        /// <summary>
        /// Requires a date is not max value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(TimeSpan val, string key) =>
            IsNotMaxValue(val, key, FluntErrorMessages.IsNotMaxValueErrorMessage(key, TimeSpan.MaxValue.ToString()));


        /// <summary>
        /// Requires a date is not max value
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> IsNotMaxValue(TimeSpan val, string key, string message)
        {
            if (val == TimeSpan.MaxValue)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region AreEquals

        /// <summary>
        /// Require dates are equals
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="comparer">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> AreEquals(TimeSpan val, TimeSpan comparer, string key)
            => AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Require dates are equals
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="comparer">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Customer error message</param>
        /// <returns></returns>
        public Contract<T> AreEquals(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region AreNotEquals
        /// <summary>
        /// Requires two dates are not equals
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="comparer">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(TimeSpan val, TimeSpan comparer, string key)
            => AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two dates are not equals
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="comparer">date</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(TimeSpan val, TimeSpan comparer, string key, string message)
        {
            if (val == comparer)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region Contains
        /// <summary>
        /// Requires a list contains a date
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="list">list of dates</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> Contains(TimeSpan val, IEnumerable<TimeSpan> list, string key)
            => Contains(val, list, key, FluntErrorMessages.ContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list contains a date
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="list">list of dates</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> Contains(TimeSpan val, IEnumerable<TimeSpan> list, string key, string message)
        {
            if (list.Any(x => x == val) == false)
                AddNotification(key, message);

            return this;
        }
        #endregion

        #region NotContains
        /// <summary>
        /// Requires a list not contains a date
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="list">list of dates</param>
        /// <param name="key">Key or Property Name</param>
        /// <returns></returns>
        public Contract<T> NotContains(TimeSpan val, IEnumerable<TimeSpan> list, string key)
            => NotContains(val, list, key, FluntErrorMessages.NotContainsErrorMessage(key, val.ToString()));

        /// <summary>
        /// Requires a list not contains a date
        /// </summary>
        /// <param name="val">date</param>
        /// <param name="list">list of dates</param>
        /// <param name="key">Key or Property Name</param>
        /// <param name="message">Custom error message</param>
        /// <returns></returns>
        public Contract<T> NotContains(TimeSpan val, IEnumerable<TimeSpan> list, string key, string message)
        {
            if (list.Any(x => x == val) == true)
                AddNotification(key, message);

            return this;
        }
        #endregion
    }
}
