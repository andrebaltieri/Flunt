using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires a string is an email
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsEmail(string val, string key) =>
            IsEmail(val, key, FluntErrorMessages.IsEmailErrorMessage(key));

        /// <summary>
        /// Requires a string is an email
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsEmail(string val, string key, string message)
        {
            return Matches(val, FluntRegexPatterns.EmailRegexPattern, key, message);
        }

        /// <summary>
        /// Requires a string is an email or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsEmailOrEmpty(string val, string key) =>
            IsEmailOrEmpty(val, key, FluntErrorMessages.IsEmailOrEmptyErrorMessage(key));

        /// <summary>
        /// Requires a string is an email or empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsEmailOrEmpty(string val, string key, string message)
        {
            return string.IsNullOrEmpty(val) ?
                this :
                IsEmail(val, key, message);
        }

        /// <summary>
        /// Requires a string is not an email
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotEmail(string val, string key) =>
            IsNotEmail(val, key, FluntErrorMessages.IsNotEmailErrorMessage(key));

        /// <summary>
        /// Requires a string is not an email
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotEmail(string val, string key, string message)
        {
            return NotMatches(val, FluntRegexPatterns.EmailRegexPattern, key, message);
        }
    }
}