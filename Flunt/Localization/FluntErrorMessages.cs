namespace Flunt.Localization
{
    public static class FluntErrorMessages
    {
        public static string AndLocalizationErrorMessageLocalization = "and";
        public static string OrLocalizationErrorMessageLocalization = "or";
        public static string IsFalseLocalizationErrorMessage = $"should not be true";
        public static string IsTrueLocalizationErrorMessage = $"should not be false";
        public static string IsEmptyLocalizationErrorMessage = $"should be empty";
        public static string IsNotEmptyLocalizationErrorMessage = $"should not be empty";
        public static string IsNotNullOrEmptyLocalizationErrorMessage = $"should not be null or empty";
        public static string IsNotNullLocalizationErrorMessage = $"should not be null";
        public static string IsNullLocalizationErrorMessage = $"should be null";
        public static string IsNullOrEmptyLocalizationErrorMessage = $"should be null or empty";
        public static string IsNullOrWhiteSpaceLocalizationErrorMessage = "should be null or white space";
        public static string IsNotNullOrWhiteSpaceLocalizationErrorMessage = "should not be null or white space";
        public static string IsGreaterThanLocalizationErrorMessage = $"should be greater than";
        public static string IsGreaterOrEqualsThanLocalizationErrorMessage = $"should be greater or equals than";
        public static string IsLowerThanLocalizationErrorMessage = $"should be lower than";
        public static string IsLowerOrEqualsThanLocalizationErrorMessage = $"should be lower or equals than";
        public static string IsBetweenLocalizationErrorMessage = $"should be between";
        public static string IsNotBetweenLocalizationErrorMessage = $"should not be between";
        public static string IsMinValueLocalizationErrorMessage = $"should be";
        public static string IsNotMinValueLocalizationErrorMessage = $"should not be";
        public static string IsMaxValueLocalizationErrorMessage = $"should be";
        public static string IsNotMaxValueLocalizationErrorMessage = $"should not be";
        public static string AreEqualsLocalizationErrorMessage = $"should be equals";
        public static string AreNotEqualsLocalizationErrorMessage = $"should not be equals";
        public static string ContainsLocalizationErrorMessage = $"should contain value";
        public static string NotContainsLocalizationErrorMessage = $"should not contain value";
        public static string IsCreditCardLocalizationErrorMessage = $"should be a credit card number";
        public static string MatchesLocalizationErrorMessage = $"does not matches pattern";
        public static string NotMatchesLocalizationErrorMessage = $"should not matches pattern";
        public static string IsEmailLocalizationErrorMessage = $"should be an email";
        public static string IsEmailOrEmptyLocalizationErrorMessage = $"should be an email or empty";
        public static string IsNotEmailLocalizationErrorMessage = $"should not be an email";
        public static string IsUrlLocalizationErrorMessage = "should be an URL";
        public static string IsNotUrlLocalizationErrorMessage = "should not be an URL";

        public static string IsFalseErrorMessage(string key) => $"{key} {IsFalseLocalizationErrorMessage}";
        public static string IsTrueErrorMessage(string key) => $"{key} {IsTrueLocalizationErrorMessage}";
        public static string IsEmptyErrorMessage(string key) => $"{key} {IsEmptyLocalizationErrorMessage}";
        public static string IsNotEmptyErrorMessage(string key) => $"{key} {IsNotEmptyLocalizationErrorMessage}";
        public static string IsNotNullOrEmptyErrorMessage(string key) => $"{key} {IsNotNullOrEmptyLocalizationErrorMessage}";
        public static string IsNotNullErrorMessage(string key) => $"{key} {IsNotNullLocalizationErrorMessage}";
        public static string IsNullErrorMessage(string key) => $"{key} {IsNullLocalizationErrorMessage}";
        public static string IsNullOrEmptyErrorMessage(string key) => $"{key} {IsNullOrEmptyLocalizationErrorMessage}";
        public static string IsNullOrWhiteSpaceErrorMessage(string key) => $"{key} {IsNullOrWhiteSpaceLocalizationErrorMessage}";
        public static string IsNotNullOrWhiteSpaceErrorMessage(string key) => $"{key} {IsNotNullOrWhiteSpaceLocalizationErrorMessage}";
        public static string IsGreaterThanErrorMessage(string key, string comparer) => $"{key} {IsGreaterThanLocalizationErrorMessage} {comparer}";
        public static string IsGreaterOrEqualsThanErrorMessage(string key, string comparer) => $"{key} {IsGreaterOrEqualsThanLocalizationErrorMessage} {comparer}";
        public static string IsLowerThanErrorMessage(string key, string comparer) => $"{key} {IsLowerThanLocalizationErrorMessage} {comparer}";
        public static string IsLowerOrEqualsThanErrorMessage(string key, string comparer) => $"{key} {IsLowerOrEqualsThanLocalizationErrorMessage} {comparer}";
        public static string IsBetweenErrorMessage(string key, string start, string end) => $"{key} {IsBetweenLocalizationErrorMessage} {start} {AndLocalizationErrorMessageLocalization} {end}";
        public static string IsNotBetweenErrorMessage(string key, string start, string end) => $"{key} {IsNotBetweenLocalizationErrorMessage} {start} {AndLocalizationErrorMessageLocalization} {end}";
        public static string IsMinValueErrorMessage(string key, string minValue) => $"{key} {IsMinValueLocalizationErrorMessage} {minValue}";
        public static string IsNotMinValueErrorMessage(string key, string minValue) => $"{key} {IsNotMinValueLocalizationErrorMessage} {minValue}";
        public static string IsMaxValueErrorMessage(string key, string maxValue) => $"{key} {IsMaxValueLocalizationErrorMessage} {maxValue}";
        public static string IsNotMaxValueErrorMessage(string key, string maxValue) => $"{key} {IsNotMaxValueLocalizationErrorMessage} {maxValue}";
        public static string AreEqualsErrorMessage(string val, string comparer) => $"{val} {AreEqualsLocalizationErrorMessage} {comparer}";
        public static string AreNotEqualsErrorMessage(string val, string comparer) => $"{val} {AreNotEqualsLocalizationErrorMessage} {comparer}";
        public static string ContainsErrorMessage(string key, string comparer) => $"{key} {ContainsLocalizationErrorMessage} {comparer}";
        public static string NotContainsErrorMessage(string key, string comparer) => $"{key} {NotContainsLocalizationErrorMessage} {comparer}";
        public static string IsCreditCardErrorMessage(string key) => $"{key} {IsCreditCardLocalizationErrorMessage}";
        public static string MatchesErrorMessage(string key, string pattern) => $"{key} {MatchesLocalizationErrorMessage} {pattern}";
        public static string NotMatchesErrorMessage(string key, string pattern) => $"{key} {NotMatchesLocalizationErrorMessage} {pattern}";
        public static string IsEmailErrorMessage(string key) => $"{key} {IsEmailLocalizationErrorMessage}";
        public static string IsEmailOrEmptyErrorMessage(string key) => $"{key}{IsEmailOrEmptyLocalizationErrorMessage}";
        public static string IsNotEmailErrorMessage(string key) => $"{key} {IsNotEmailLocalizationErrorMessage}";
        public static string IsUrlErrorMessage(string key) => $"{key} {IsUrlLocalizationErrorMessage}";
        public static string IsNotUrlErrorMessage(string key) => $"{key} {IsNotUrlLocalizationErrorMessage}";
        public static string IsUrlOrEmptyErrorMessage(string key) => $"{key} {IsUrlLocalizationErrorMessage} {OrLocalizationErrorMessageLocalization} {IsEmptyLocalizationErrorMessage}";
        public static string IsNotUrlOrEmptyErrorMessage(string key) => $"{key} {IsNotUrlLocalizationErrorMessage} {OrLocalizationErrorMessageLocalization} {IsEmptyLocalizationErrorMessage}";
    }
}
