namespace Flunt.Localization
{
    public static class ContractLocalization
    {
        public static string DateFormat = "MM/DD/yyyy";
        public static string DateTimeFormat = "MM/DD/yyyy hh:mm";

        public static string IsFalseErrorMessage(string key) => $"{key} should not be true";
        public static string IsTrueErrorMessage(string key) => $"{key} should not be false";
        public static string IsEmptyErrorMessage(string key) => $"{key} should be empty";
        public static string IsNotEmptyErrorMessage(string key) => $"{key} should not be empty";
        public static string IsNotNullOrEmptyErrorMessage(string key) => $"{key} should not be null or empty";
        public static string IsNotNullErrorMessage(string key) => $"{key} should not be null";
        public static string IsNullErrorMessage(string key) => $"{key} should be null";
        public static string IsGreaterThanErrorMessage(string key, string comparer) => $"{key} should be greater than {comparer}";
        public static string IsGreaterOrEqualsThanErrorMessage(string key, string comparer) => $"{key} should be greater or equals than {comparer}";
        public static string IsLowerThanErrorMessage(string key, string comparer) => $"{key} should be lower than {comparer}";
        public static string IsLowerOrEqualsThanErrorMessage(string key, string comparer) => $"{key} should be lower or equals than {comparer}";
        public static string IsBetweenErrorMessage(string key, string start, string end) => $"{key} should be between {start} and {end}";
        public static string IsNotBetweenErrorMessage(string key, string start, string end) => $"{key} should not be between {start} and {end}";
        public static string IsMinValueErrorMessage(string key, string minValue) => $"{key} should be {minValue}";
        public static string IsNotMinValueErrorMessage(string key, string minValue) => $"{key} should not be {minValue}";
        public static string IsMaxValueErrorMessage(string key, string maxValue) => $"{key} should be {maxValue}";
        public static string IsNotMaxValueErrorMessage(string key, string maxValue) => $"{key} should not be {maxValue}";
        public static string AreEqualsErrorMessage(string val, string comparer) => $"{val} should be equals {comparer}";
        public static string AreNotEqualsErrorMessage(string val, string comparer) => $"{val} should not be equals {comparer}";
        public static string ContainsErrorMessage(string key, string comparer) => $"{key} should contain value {comparer}";
        public static string NotContainsErrorMessage(string key, string comparer) => $"{key} should not contain value {comparer}";

    }
}
