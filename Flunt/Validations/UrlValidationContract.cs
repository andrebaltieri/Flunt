using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires a string is an URL
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsUrl(string val, string key) =>
            IsUrl(val, key, FluntErrorMessages.IsUrlErrorMessage(key));

        /// <summary>
        /// Requires a string is an URL
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsUrl(string val, string key, string message) =>
            Matches(val, FluntRegexPatterns.UrlRegexPattern, key, message);

        /// <summary>
        /// Requires a string is an URL or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsUrlOrEmpty(string val, string key) =>
            IsUrlOrEmpty(val, key, FluntErrorMessages.IsUrlOrEmptyErrorMessage(key));

        /// <summary>
        /// Requires a string is an URL or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsUrlOrEmpty(string val, string key, string message)
        {
            return string.IsNullOrEmpty(val) ?
                this :
                Matches(val, FluntRegexPatterns.UrlRegexPattern, key, message);
        }

        /// <summary>
        /// Requires a string is not an URL
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotUrl(string val, string key) =>
            IsNotUrl(val, key, FluntErrorMessages.IsNotUrlErrorMessage(key));

        /// <summary>
        /// Requires a string is not an URL
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotUrl(string val, string key, string message) =>
            NotMatches(val, FluntRegexPatterns.UrlRegexPattern, key, message);

        /// <summary>
        /// Requires a string is not an URL or is empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotUrlOrEmpty(string val, string key) =>
            IsNotUrlOrEmpty(val, key, FluntErrorMessages.IsNotUrlOrEmptyErrorMessage(key));

        /// <summary>
        /// Requires a string is not an URL or is empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotUrlOrEmpty(string val, string key, string message)
        {
            return string.IsNullOrEmpty(val) ?
                this :
                NotMatches(val, FluntRegexPatterns.UrlRegexPattern, key, message);
        }
    }
}