using System.Collections.Generic;
using System.Linq;
using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires a list is null
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull<TList>(IEnumerable<TList> val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a list is null
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list is not null
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull<TList>(IEnumerable<TList> val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a list is not null
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list contains no elements
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsEmpty<TList>(IEnumerable<TList> val, string key) =>
            IsEmpty(val, key, FluntErrorMessages.IsEmptyErrorMessage(key));

        /// <summary>
        /// Requires a list contains no elements
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsEmpty<TList>(IEnumerable<TList> val, string key, string message)
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
        /// <returns></returns>
        public Contract<T> IsNotEmpty<TList>(IEnumerable<TList> val, string key) =>
            IsNotEmpty(val, key, FluntErrorMessages.IsNotEmptyErrorMessage(key));

        /// <summary>
        /// Requires a list contains at least one element
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotEmpty<TList>(IEnumerable<TList> val, string key, string message)
        {
            if (val.Any() == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list count is greater than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a list count is greater than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() <= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list count is greater or equals than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a list count is greater or equals than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list count is lower than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a list count is lower than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsLowerThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a list count is lower or equals than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a list count is lower or equals than
        /// </summary>
        /// <typeparam name="TList"></typeparam>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan<TList>(IEnumerable<TList> val, int comparer, string key, string message)
        {
            if (val?.Count() > comparer)
                AddNotification(key, message);

            return this;
        }
    }
}
