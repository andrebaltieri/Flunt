using Flunt.Localization;

namespace Flunt.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires a string is a passport number
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsPassport(string val, string key) =>
            IsPassport(val, key, FluntErrorMessages.IsPassportErrorMessage(key));

        /// <summary>
        /// Requires a string is a passport number
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsPassport(string val, string key, string message) => 
            Matches(val, FluntRegexPatterns.PassportRegexPattern, key, message);
    }
}
