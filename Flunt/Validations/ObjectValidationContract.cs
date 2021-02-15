using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires an object is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(object val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires an object is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(object val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires an object is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(object val, string key) =>
            IsNotNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires an object is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(object val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two objects are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(object val, object comparer, string key) =>
            AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val?.ToString(), comparer?.ToString()));

        /// <summary>
        /// Requires two objects are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(object val, object comparer, string key, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (val.Equals(comparer) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two objects are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(object val, object comparer, string key) =>
            AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val?.ToString(), comparer?.ToString()));

        /// <summary>
        /// Requires two objects are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(object val, object comparer, string key, string message)
        {
            if (val == null || comparer == null)
                return this;

            if (val.Equals(comparer))
                AddNotification(key, message);

            return this;
        }
    }
}
