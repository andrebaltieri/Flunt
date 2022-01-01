using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires a string is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNull(string val, string key) =>
            IsNull(val, key, FluntErrorMessages.IsNullErrorMessage(key));

        /// <summary>
        /// Requires a string is null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNull(string val, string key, string message)
        {
            if (val != null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(string val, string key) =>
            IsNotNull(val, key, FluntErrorMessages.IsNotNullErrorMessage(key));

        /// <summary>
        /// Requires a string is not null
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNull(string val, string key, string message)
        {
            if (val == null)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string is null or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNullOrEmpty(string val, string key) =>
            IsNullOrEmpty(val, key, FluntErrorMessages.IsNullOrEmptyErrorMessage(key));

        /// <summary>
        /// Requires a string is null or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNullOrEmpty(string val, string key, string message)
        {
            if (string.IsNullOrEmpty(val) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string is not null or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrEmpty(string val, string key) =>
            IsNotNullOrEmpty(val, key, FluntErrorMessages.IsNotNullOrEmptyErrorMessage(key));

        /// <summary>
        /// Requires a string is not null or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrEmpty(string val, string key, string message)
        {
            if (string.IsNullOrEmpty(val))
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string is null or white space
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNullOrWhiteSpace(string val, string key) =>
            IsNullOrWhiteSpace(val, key, FluntErrorMessages.IsNullOrWhiteSpaceErrorMessage(key));

        /// <summary>
        /// Requires a string is null or white space
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNullOrWhiteSpace(string val, string key, string message)
        {
            if (string.IsNullOrWhiteSpace(val) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string is not null or white space
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrWhiteSpace(string val, string key) =>
            IsNotNullOrWhiteSpace(val, key, FluntErrorMessages.IsNotNullOrWhiteSpaceErrorMessage(key));

        /// <summary>
        /// Requires a string is not null or white space
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotNullOrWhiteSpace(string val, string key, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two strings are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(string val, string comparer, string key) =>
            AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val, comparer));

        /// <summary>
        /// Requires two strings are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(string val, string comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string have a len
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(string val, int comparer, string key) =>
            AreEquals(val, comparer, key, FluntErrorMessages.AreEqualsErrorMessage(val, comparer.ToString()));

        /// <summary>
        /// Requires a string have a len
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length != comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two strings are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(string val, string comparer, string key) =>
            AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val, comparer));

        /// <summary>
        /// Requires two strings are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(string val, string comparer, string key, string message)
        {
            if (val == comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string do not have a len
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(string val, int comparer, string key) =>
            AreNotEquals(val, comparer, key, FluntErrorMessages.AreNotEqualsErrorMessage(val, comparer.ToString()));

        /// <summary>
        /// Requires a string do not have a len
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length == comparer)
                AddNotification(key, message);

            return this;
        }


        /// <summary>
        /// Requires a string contains
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> Contains(string val, string comparer, string key) =>
            Contains(val, comparer, key, FluntErrorMessages.ContainsErrorMessage(val, comparer));

        /// <summary>
        /// Requires a string contains
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> Contains(string val, string comparer, string key, string message)
        {
            if (string.IsNullOrEmpty(val))
                val = string.Empty;

            if (val.Contains(comparer) == false)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string not contains
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> NotContains(string val, string comparer, string key) =>
            NotContains(val, comparer, key, FluntErrorMessages.NotContainsErrorMessage(val, comparer));

        /// <summary>
        /// Requires a string not contains
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> NotContains(string val, string comparer, string key, string message)
        {
            if (string.IsNullOrEmpty(val))
                val = string.Empty;

            if (val.Contains(comparer))
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string len is greater than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(string val, int comparer, string key) =>
            IsGreaterThan(val, comparer, key, FluntErrorMessages.IsGreaterThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a string is greater than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterThan(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length <= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string len is greater or equals than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(string val, int comparer, string key) =>
            IsGreaterOrEqualsThan(val, comparer, key, FluntErrorMessages.IsGreaterOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a string len is greater or equals than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsGreaterOrEqualsThan(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length < comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string len is lower than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(string val, int comparer, string key) =>
            IsLowerThan(val, comparer, key, FluntErrorMessages.IsLowerThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a string len is lower than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsLowerThan(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length >= comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a string len is lower or equals than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(string val, int comparer, string key) =>
            IsLowerOrEqualsThan(val, comparer, key, FluntErrorMessages.IsLowerOrEqualsThanErrorMessage(key, comparer.ToString()));

        /// <summary>
        /// Requires a string len is lower or equals than
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsLowerOrEqualsThan(string val, int comparer, string key, string message)
        {
            if (val == null)
                return this;

            if (val.Length > comparer)
                AddNotification(key, message);

            return this;
        }
        
        
        /// <summary>
        /// Requires a string len is between
        /// </summary>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsBeetween(string val, int min, int max, string key, string message)
        {
            if (val == null)
                return this;

            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                return this;

            if (val.Length < min || val.Length > max)
                AddNotification(key, message);

            return this;
        }
    }
}